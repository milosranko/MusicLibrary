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
            return Enumerable.Empty<string>();

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
                [nameof(MusicLibraryDocument.Text)],
                QueryTypesEnum.Text),
            SearchFieldsEnum.Genre => PerformSearch(
                query,
                [query],
                [nameof(MusicLibraryDocument.Genre)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(MusicLibraryDocument.Artist), [] }, { nameof(MusicLibraryDocument.Album), [] } }),
            SearchFieldsEnum.Year => PerformSearch(
                query,
                [query],
                [nameof(MusicLibraryDocument.Year)],
                QueryTypesEnum.Numeric,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(MusicLibraryDocument.Artist), [] }, { nameof(MusicLibraryDocument.Album), [] } }),
            SearchFieldsEnum.Extension => PerformSearch(
                query,
                [query],
                [nameof(MusicLibraryDocument.Extension)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(MusicLibraryDocument.Extension), [] } }),
            SearchFieldsEnum.Release => PerformSearch(
                query,
                terms,
                [nameof(MusicLibraryDocument.Artist), nameof(MusicLibraryDocument.Album)],
                QueryTypesEnum.MultiTerm,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(MusicLibraryDocument.Year), [] } }),
            SearchFieldsEnum.Artist => PerformSearch(
                query,
                [query],
                [nameof(MusicLibraryDocument.Artist)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(MusicLibraryDocument.Artist), [query] }, { nameof(MusicLibraryDocument.Album), [] } }),
            _ => PerformSearch(
                query.RemoveSpecialCharacters().ToLower(),
                terms,
                [nameof(MusicLibraryDocument.Text)],
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
            TotalFilesByExtension = _searchIndexEngine.CountDocuments(null), // GetMostFrequentTerms(searcher, nameof(Content.Extension)),
            TotalHiResFiles = _searchIndexEngine.Search(new SearchRequest
            {
                Text = "hr flac",
                SearchFields = new Dictionary<string, string?> { { nameof(MusicLibraryDocument.Text), string.Empty } },
                QueryType = QueryTypesEnum.Text,
                Pagination = new Pagination(int.MaxValue, 0)
            }).TotalHits,
            ReleaseYears = _searchIndexEngine.CountDocuments(null), //GetMostFrequentTermsNumeric(searcher, nameof(Content.Year)),
            GenreCount = _searchIndexEngine.CountDocuments(null), //GetMostFrequentTerms(searcher, nameof(Content.Genre)),
            LatestAdditions = null // GetLatestAddedItems(searcher, nameof(Content.ModifiedDate), 500)
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
