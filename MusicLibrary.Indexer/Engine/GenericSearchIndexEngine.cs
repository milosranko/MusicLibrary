using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Util;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Enums;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Indexer.Engine;

public class GenericSearchIndexEngine<T> : ISearchIndexEngine<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private readonly IDocumentReader<T> _documentReader;
    private readonly IDocumentWriter<T> _documentWriter;

    public GenericSearchIndexEngine()
    {
        _documentReader = new DocumentReader<T>();
        _documentWriter = new DocumentWriter<T>();
    }

    public void AddOrUpdateDocuments(ConcurrentBag<T> contents, CancellationToken ct = default)
    {
        if (contents.IsEmpty) return;

        _documentWriter.Init();
        _documentReader.Init(_documentWriter.GetDirectoryReader());

        var tasks = contents.Select(x => Task.Run(() =>
        {
            if (_documentReader.DocumentExists(x.Id))
                _documentWriter.Update(x);
            else
                _documentWriter.Add(x);
        }));

        Task.WhenAll(tasks).Wait(ct);

        _documentWriter.Commit();
        _documentWriter.Dispose();
        _documentReader.Dispose();
    }

    public void DeleteAll()
    {
        _documentWriter.Init();
        _documentWriter.DeleteAll();
        _documentWriter.Dispose();
    }

    public void DeleteById(string[] ids)
    {
        _documentWriter.Init();
        _documentWriter.DeleteById(ids);
        _documentWriter.Dispose();
    }

    public IEnumerable<string> SkipExistingDocuments(string[] ids)
    {
        if (ids.Length == 0)
            return [];

        var result = new Collection<string>();

        foreach (var id in ids)
        {
            if (_documentReader.DocumentExists(id))
            {
                result.Add(id);
            }
        }

        return result;
    }

    public IEnumerable<T> GetByIds(string[] ids)
    {
        _documentReader.Init();
        return _documentReader.GetByIds(ids);
    }

    public bool IndexNotExistsOrEmpty()
    {
        _documentReader.Init();
        return _documentReader.IndexNotExistsOrEmpty();
    }

    public SearchResult<T> Search(SearchRequest request)
    {
        _documentReader.Init();
        return _documentReader.Search(request);
    }

    public IEnumerable<string> GetAllIndexedIds()
    {
        _documentReader.Init();

        var res = new Collection<string>();
        var fields = MultiFields.GetFields(_documentReader.Reader);
        var terms = fields.GetTerms(nameof(Content.Id));
        var termsEnum = terms.GetEnumerator(null);

        while (termsEnum.MoveNext() == true)
        {
            res.Add(termsEnum.Term.Utf8ToString());
        }

        return res;
    }

    public IndexCounts GetIndexStatistics()
    {
        _documentReader.Init();
        var searcher = new IndexSearcher(_documentReader.Reader);

        return new IndexCounts
        {
            TotalFiles = _documentReader.Reader?.NumDocs,
            TotalFilesByExtension = GetMostFrequentTerms(searcher, nameof(Content.Extension)),
            TotalHiResFiles = Search(new SearchRequest
            {
                Text = QueryParser.Escape("hr flac"),
                SearchFields = new Dictionary<string, string?> { { nameof(Content.Text), string.Empty } },
                QueryType = QueryTypesEnum.Text,
                Pagination = new Pagination(int.MaxValue, 0)
            }).TotalHits,
            ReleaseYears = GetMostFrequentTermsNumeric(searcher, nameof(Content.Year)),
            GenreCount = GetMostFrequentTerms(searcher, nameof(Content.Genre)),
            LatestAdditions = GetLatestAddedItems(searcher, nameof(Content.ModifiedDate), 500)
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
            folder = Path.GetDirectoryName(searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(Content.Id)));
            artist = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(Content.Artist));
            release = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(Content.Album));

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
                collector.TotalHits > 0)
                res.Add(term.ToString(), collector.TotalHits);
        }

        return res;
    }
}
