﻿using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Core;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
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
    public class SearchIndexEngine
    {
        private const LuceneVersion AppLuceneVersion = LuceneVersion.LUCENE_48;
        private readonly Directory _directory;
        private readonly Analyzer _analyzer;

        private IndexWriter IndexWriter => 
            new IndexWriter(_directory, new IndexWriterConfig(AppLuceneVersion, _analyzer));

        public SearchIndexEngine()
        {
            _directory = DirectoryProvider.CreateDocumentIndex();
            _analyzer = new WhitespaceAnalyzer(AppLuceneVersion);
        }

        public void AddOrUpdateDocuments(ConcurrentBag<Content> contents, CancellationToken ct)
        {
            if (contents.IsEmpty) return;

            using var writer = IndexWriter;
            var reader = DirectoryReader.Open(_directory);
            var searcher = new IndexSearcher(reader);

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
            var reader = DirectoryReader.Open(_directory);
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
            using var indexReader = DirectoryReader.Open(_directory);
            var searcher = new IndexSearcher(indexReader);
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
            using var indexReader = DirectoryReader.Open(_directory);
            var res = new Collection<string>();
            var fields = MultiFields.GetFields(indexReader);
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
            using var indexReader = DirectoryReader.Open(_directory);
            var searcher = new IndexSearcher(indexReader);

            return new IndexCounts
            {
                TotalFiles = indexReader.NumDocs,
                TotalFilesByExtension = GetMostFrequentTerms(searcher, FieldNames.Extension),
                ReleaseYears = GetMostFrequentTermsNumeric(searcher, FieldNames.Year),
                GenreCount = GetMostFrequentTerms(searcher, FieldNames.Genre),
                LatestAdditions = GetLatestAddedItems(searcher, FieldNames.ModifiedDate, 400)
            };
        }

        private ICollection<ValueTuple<string, string>> GetLatestAddedItems(IndexSearcher searcher, string field, int count)
        {
            var res = new Collection<ValueTuple<string, string>>();
            var query = new MatchAllDocsQuery();
            var sort = new Sort(new SortField(field, SortFieldType.INT64, true));
            var topDocs = searcher.Search(query, count, sort);
            string artist, release;

            for (int i = 0; i < topDocs.ScoreDocs.Length; i++)
            {
                artist = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(FieldNames.Artist);
                release = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(FieldNames.Album);

                if (!res.Contains((artist, release)))
                    res.Add((artist, release));

                if (res.Count == 40)
                    break;
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
            using var writer = IndexWriter;
            writer.Commit();
        }

        public void DeleteAll()
        {
            using var writer = IndexWriter;
            writer.DeleteAll();
            writer.Commit();
        }

        public void DeleteById(string[] ids)
        {
            if (ids == null || ids.Length == 0) return;

            using var writer = IndexWriter;
            writer.DeleteDocuments(ids.Select(x => new Term(FieldNames.Id, x)).ToArray());
            writer.Commit();
        }

        public bool IndexExistsOrEmpty()
        {
            if (!DirectoryReader.IndexExists(_directory)) return false;

            return DirectoryReader.Open(_directory).NumDocs > 0;
        }
    }
}
