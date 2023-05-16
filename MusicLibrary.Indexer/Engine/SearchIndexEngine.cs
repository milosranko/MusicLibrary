using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Core;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Util;
using MusicLibrary.Indexer.ModelBuilders;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Constants;
using MusicLibrary.Indexer.Models.Enums;
using MusicLibrary.Indexer.Providers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Indexer.Engine
{
    public class SearchIndexEngine : IDisposable
    {
        private const LuceneVersion AppLuceneVersion = LuceneVersion.LUCENE_48;
        private readonly Analyzer _analyzer;
        private readonly string _indexName;

        public SearchIndexEngine()
        {
            //_directory = DirectoryProvider.GetOrCreateDocumentIndex(string.Empty);
            _analyzer = new WhitespaceAnalyzer(AppLuceneVersion);
            _indexName = string.Empty;
        }

        public SearchIndexEngine(string indexName)
        {
            //_directory = DirectoryProvider.GetOrCreateDocumentIndex(indexName);
            _analyzer = new WhitespaceAnalyzer(AppLuceneVersion);
            _indexName = indexName;
        }

        public void AddOrUpdateDocuments(ConcurrentBag<Content> contents, CancellationToken ct)
        {
            if (contents.IsEmpty) return;

            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var writer = new IndexWriter(directory, new IndexWriterConfig(AppLuceneVersion, _analyzer));
            using var reader = DirectoryReader.Open(directory);

            Parallel.ForEach(contents, new ParallelOptions { CancellationToken = ct }, content =>
            {
                var document = DocumentModelBuilders.BuildContentDocument(content);
                var indexTerm = new Term(FieldNames.Id, content.FileId);

                if (reader.DocFreq(indexTerm) == 0)
                    writer.AddDocument(document);
                else
                    writer.UpdateDocument(indexTerm, document);
            });

            writer.Commit();
        }

        public IEnumerable<string> DocumentsExists(IEnumerable<string> documents)
        {
            if (!documents.Any()) return Enumerable.Empty<string>();

            var result = new Collection<string>();
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var reader = DirectoryReader.Open(directory);
            Term indexTerm;

            foreach (var doc in documents)
            {
                indexTerm = new Term(FieldNames.Id, doc);

                if (reader.DocFreq(indexTerm) == 0)
                {
                    result.Add(doc);
                }
            }

            return result;
        }

        public SearchResult Search(SearchRequest request)
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var reader = DirectoryReader.Open(directory);
            var searcher = new IndexSearcher(reader);
            var searchResult = new SearchResult
            {
                SearchText = request.Text,
                Hits = Enumerable.Empty<SearchHit>()
            };

            Query q = null;

            switch (request.QueryType)
            {
                case QueryTypesEnum.Term:
                    q = new TermQuery(new Term(request.Fields[0], request.Text));
                    break;
                case QueryTypesEnum.MultiTerm:
                    q = new BooleanQuery();

                    if (request.Terms.Length.Equals(request.Fields.Length) && request.Terms.Length > 0)
                        for (int i = 0; i < request.Terms.Length; i++)
                            ((BooleanQuery)q).Add(new TermQuery(new Term(request.Fields[i], request.Terms[i])), Occur.MUST);
                    break;
                case QueryTypesEnum.Numeric:
                    q = NumericRangeQuery.NewInt32Range(request.Fields[0], int.Parse(request.Text), int.Parse(request.Text), true, true);
                    break;
                case QueryTypesEnum.Text:
                    var parser = new QueryParser(AppLuceneVersion, request.Fields[0], _analyzer)
                    {
                        AllowLeadingWildcard = true,
                        DefaultOperator = Operator.AND
                    };
                    q = parser.Parse(request.Text);
                    break;
            }

            var startIndex = request.Pagination.PageIndex * request.Pagination.PageSize;
            var topDocs = searcher.Search(q, startIndex + request.Pagination.PageSize);

            if (topDocs.TotalHits == 0) return searchResult;

            var hits = new List<SearchHit>(topDocs.ScoreDocs.Skip(startIndex).Count());

            foreach (var hit in topDocs.ScoreDocs.Skip(startIndex))
                hits.Add(CreateSearchHit(searcher.Doc(hit.Doc)));

            searchResult.TotalHits = topDocs.TotalHits;
            searchResult.Hits = hits.OrderBy(x => x.Name).ToList();
            searchResult.Pagination = request.Pagination;

            return searchResult;
        }

        public IEnumerable<string> GetAllIndexedIds()
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var reader = DirectoryReader.Open(directory);
            var res = new Collection<string>();
            var fields = MultiFields.GetFields(reader);
            var terms = fields.GetTerms(FieldNames.Id);
            var termsEnum = terms.GetEnumerator(null);

            while (termsEnum.MoveNext() == true)
            {
                res.Add(termsEnum.Term.Utf8ToString());
            }

            return res;
        }

        public IndexCounts GetIndexStatistics()
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var reader = DirectoryReader.Open(directory);
            var searcher = new IndexSearcher(reader);

            return new IndexCounts
            {
                TotalFiles = reader.NumDocs,
                TotalFilesByExtension = GetMostFrequentTerms(searcher, FieldNames.Extension),
                ReleaseYears = GetMostFrequentTermsNumeric(searcher, FieldNames.Year),
                GenreCount = GetMostFrequentTerms(searcher, FieldNames.Genre),
                LatestAdditions = GetLatestAddedItems(searcher, FieldNames.ModifiedDate, 500)
            };
        }

        private ICollection<ValueTuple<string, string>> GetLatestAddedItems(IndexSearcher searcher, string field, int count)
        {
            var res = new Collection<ValueTuple<string, string>>();
            var query = new MatchAllDocsQuery();
            var sort = new Sort(new SortField(field, SortFieldType.INT64, true));
            var topDocs = searcher.Search(query, count, sort);
            string artist, release, folder, prevFolder = null;

            for (int i = 0; i < topDocs.ScoreDocs.Length; i++)
            {
                folder = System.IO.Path.GetDirectoryName(searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(FieldNames.Id));
                artist = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(FieldNames.Artist);
                release = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(FieldNames.Album);

                if (!res.Contains((artist, release)) && prevFolder != folder)
                    res.Add((artist, release));

                if (res.Count == 50)
                    break;

                if (prevFolder != folder)
                    prevFolder = folder;
            }

            return res;
        }

        private IDictionary<string, int> GetMostFrequentTerms(IndexSearcher searcher, string field)
        {
            var res = new Dictionary<string, int>();
            var fields = MultiFields.GetFields(searcher.IndexReader);
            var terms = fields.GetTerms(field);
            var termsEnum = terms.GetEnumerator(null);

            while (termsEnum.MoveNext() == true)
            {
                var collector = new TotalHitCountCollector();
                searcher.Search(new TermQuery(new Term(field, termsEnum.Term)), collector);

                if (collector.TotalHits > 0)
                    res.Add(termsEnum.Term.Utf8ToString(), collector.TotalHits);
            }

            return res;
        }

        private IDictionary<string, int> GetMostFrequentTermsNumeric(IndexSearcher searcher, string field)
        {
            var res = new Dictionary<string, int>();
            var fields = MultiFields.GetFields(searcher.IndexReader);
            var terms = fields.GetTerms(field);
            var termsEnum = terms.GetEnumerator(null);
            int term;

            while (termsEnum.MoveNext() == true)
            {
                var collector = new TotalHitCountCollector();
                searcher.Search(new TermQuery(new Term(field, termsEnum.Term)), collector);
                term = NumericUtils.PrefixCodedToInt32(termsEnum.Term);

                if (!res.ContainsKey(term.ToString()) &&
                    collector.TotalHits > 0 &&
                    term > 1921)
                    res.Add(term.ToString(), collector.TotalHits);
            }

            return res;
        }

        private SearchHit CreateSearchHit(Document doc)
        {
            var id = doc.Get(FieldNames.Id);

            return new SearchHit
            {
                Id = id,
                Name = System.IO.Path.GetFileNameWithoutExtension(id),
                Tags = string.Join("|", doc.GetValues(FieldNames.Tags))
            };
        }

        public void Commit()
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var writer = new IndexWriter(directory, new IndexWriterConfig(AppLuceneVersion, _analyzer));
            writer.Commit();
        }

        public void DeleteAll()
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var writer = new IndexWriter(directory, new IndexWriterConfig(AppLuceneVersion, _analyzer));
            writer.DeleteAll();
            writer.Commit();
        }

        public void DeleteById(string[] ids)
        {
            if (ids == null || ids.Length == 0) return;

            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var writer = new IndexWriter(directory, new IndexWriterConfig(AppLuceneVersion, _analyzer));
            writer.DeleteDocuments(ids.Select(x => new Term(FieldNames.Id, x)).ToArray());
            writer.Commit();
        }

        public bool IndexNotExistsOrEmpty()
        {
            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            if (!DirectoryReader.IndexExists(directory)) return true;

            using var reader = DirectoryReader.Open(directory);
            return reader.NumDocs == 0;
        }

        public IEnumerable<SearchHit> GetById(string[] ids)
        {
            if (ids == null || ids.Length == 0)
                return Enumerable.Empty<SearchHit>();

            var hits = new Collection<SearchHit>();

            using var directory = DirectoryProvider.GetOrCreateDocumentIndex(_indexName);
            using var reader = DirectoryReader.Open(directory);
            var searcher = new IndexSearcher(reader);
            TermQuery q;

            foreach (var id in ids)
            {
                q = new TermQuery(new Term(FieldNames.Id, id));

                var res = searcher.Search(q, 1);
                if (res.TotalHits == 0) continue;

                hits.Add(CreateSearchHit(searcher.Doc(res.ScoreDocs[0].Doc)));
            }

            return hits;
        }

        public void Dispose()
        {
            _analyzer.Dispose();
        }
    }
}
