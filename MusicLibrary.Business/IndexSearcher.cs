using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Business;

public class IndexSearcher
{
    private readonly ISearchIndexEngine<MusicLibraryDocument> _searchIndexEngine;
    public IEnumerable<string> SharedIndexes;

    public IndexSearcher()
    {
        SharedIndexes = GetSharedIndexes();
        _searchIndexEngine = new GenericSearchIndexEngine<MusicLibraryDocument>();
    }

    public IndexSearcher(string indexName)
    {
        _searchIndexEngine = new GenericSearchIndexEngine<MusicLibraryDocument>();
    }

    public bool IndexExists()
    {
        return !_searchIndexEngine.IndexNotExistsOrEmpty();
    }

    private IEnumerable<string> GetSharedIndexes()
    {
        if (!Directory.Exists(Constants.LocalAppDataShares))
            return [];

        return Directory.EnumerateDirectories(Constants.LocalAppDataShares)
            .Select(x => x.Split(Path.DirectorySeparatorChar)
            .Last());
    }

    public Task<SearchResult<MusicLibraryDocument>> Search(string query, string[]? terms, SearchFieldsEnum searchField)
    {
        return searchField switch
        {
            SearchFieldsEnum.Text => PerformSearch(
                query.RemoveSpecialCharacters().ToLower(),
                terms,
                [_searchIndexEngine.GetFieldName(x => x.Text)],
                QueryTypesEnum.Text),
            SearchFieldsEnum.Genre => PerformSearch(
                query,
                [query],
                [_searchIndexEngine.GetFieldName(x => x.Genre)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { _searchIndexEngine.GetFieldName(x => x.Artist), [] }, { _searchIndexEngine.GetFieldName(x => x.Release), [] } }),
            SearchFieldsEnum.Year => PerformSearch(
                query,
                [query],
                [_searchIndexEngine.GetFieldName(x => x.Year)],
                QueryTypesEnum.Numeric,
                new Dictionary<string, IEnumerable<string?>?> { { _searchIndexEngine.GetFieldName(x => x.Artist), [] }, { _searchIndexEngine.GetFieldName(x => x.Release), [] } }),
            SearchFieldsEnum.Extension => PerformSearch(
                query,
                [query],
                [_searchIndexEngine.GetFieldName(x => x.Extension)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { _searchIndexEngine.GetFieldName(x => x.Extension), [] } }),
            SearchFieldsEnum.Release => PerformSearch(
                query,
                terms,
                [_searchIndexEngine.GetFieldName(x => x.Artist), _searchIndexEngine.GetFieldName(x => x.Release)],
                QueryTypesEnum.MultiTerm,
                new Dictionary<string, IEnumerable<string?>?> { { _searchIndexEngine.GetFieldName(x => x.Year), [] } }),
            SearchFieldsEnum.Artist => PerformSearch(
                query,
                [query],
                [_searchIndexEngine.GetFieldName(x => x.Artist)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { _searchIndexEngine.GetFieldName(x => x.Artist), [query] }, { _searchIndexEngine.GetFieldName(x => x.Release), [] } }),
            _ => PerformSearch(
                query.RemoveSpecialCharacters().ToLower(),
                terms,
                [_searchIndexEngine.GetFieldName(x => x.Text)],
                QueryTypesEnum.Text),
        };
    }

    public IEnumerable<MusicLibraryDocument> GetSearchResultByIds(string[] ids)
    {
        if (_searchIndexEngine.IndexNotExistsOrEmpty())
            return [];

        return _searchIndexEngine.GetByIds(ids);
    }

    public Task<IndexCounts> GetIndexCounts()
    {
        if (_searchIndexEngine.IndexNotExistsOrEmpty())
            return Task.FromResult(IndexCounts.Empty);

        return Task.FromResult(new IndexCounts
        {
            TotalFiles = _searchIndexEngine.CountDocuments(null).First().Value,
            TotalFilesByExtension = _searchIndexEngine.CountDocuments(new CounterRequest
            {
                Field = _searchIndexEngine.GetFieldName(x => x.Extension)
            }),
            TotalHiResFiles = _searchIndexEngine.Search(new SearchRequest
            {
                Text = "hr flac",
                SearchFields = new Dictionary<string, string?> { { _searchIndexEngine.GetFieldName(x => x.Text), string.Empty } },
                QueryType = QueryTypesEnum.Text,
                Pagination = new Pagination(int.MaxValue, 0)
            }).TotalHits,
            ReleaseYears = _searchIndexEngine.CountDocuments(new CounterRequest
            {
                Field = _searchIndexEngine.GetFieldName(x => x.Year),
                IsNumeric = true
            }),
            GenreCount = _searchIndexEngine.CountDocuments(new CounterRequest
            {
                Field = _searchIndexEngine.GetFieldName(x => x.Genre)
            }),
            LatestAdditions = _searchIndexEngine.GetLatestAddedItems(new CounterRequest
            {
                Field = _searchIndexEngine.GetFieldName(x => x.Release),
                AdditionalField = _searchIndexEngine.GetFieldName(x => x.Artist),
                SortByField = _searchIndexEngine.GetFieldName(x => x.ModifiedDate),
                IsNumeric = false,
                Top = 50
            })
        });
    }

    private Task<SearchResult<MusicLibraryDocument>> PerformSearch(
        string query,
        string[]? terms,
        string[] fields,
        QueryTypesEnum queryType,
        IDictionary<string, IEnumerable<string?>?>? facets = null)
    {
        if (string.IsNullOrEmpty(query) && (terms == null || terms.Length == 0))
            return Task.FromResult(SearchResult<MusicLibraryDocument>.Empty());

        if (fields == null || fields.Length == 0)
            return Task.FromResult(SearchResult<MusicLibraryDocument>.Empty());

        var searchFields = new Dictionary<string, string?>(fields.Length);

        for (var i = 0; i < fields.Length; i++)
        {
            searchFields.Add(fields[i], terms is not null && i < terms.Length ? terms[i] : string.Empty);
        }

        var searchRequest = new SearchRequest
        {
            Text = query,
            SearchFields = searchFields,
            QueryType = queryType,
            Pagination = new Pagination(int.MaxValue, 0),
            Facets = facets,
            SearchType = SearchType.ExactMatch
        };

        return Task.FromResult(_searchIndexEngine.Search(searchRequest));
    }
}
