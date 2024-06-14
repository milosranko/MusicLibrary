using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Extensions;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Dto;
using MusicLibrary.Indexer.Models.Enums;
using MusicLibrary.Indexer.Models.Requests;

namespace MusicLibrary.Business;

public class IndexSearcher
{
    private readonly ISearchIndexEngine<MusicLibraryDocument> _searchIndexEngine;
    public IEnumerable<string> SharedIndexes;

    public IndexSearcher(IndexOptions options)
    {
        SharedIndexes = GetSharedIndexes();
        _searchIndexEngine = new GenericSearchIndexEngine<MusicLibraryDocument>(options);
    }

    public IndexSearcher(IndexOptions options, string indexName)
    {
        _searchIndexEngine = new GenericSearchIndexEngine<MusicLibraryDocument>(options, indexName);
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

    public SearchResultDto<MusicLibraryDocument> Search(string query, string[]? terms, SearchFieldsEnum searchField)
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

    public IndexCounts GetIndexCounts()
    {
        if (_searchIndexEngine.IndexNotExistsOrEmpty())
            return IndexCounts.Empty;

        var totalFilesTask = Task.Run(() => _searchIndexEngine.CountDocuments(null));
        var totalFilesByExtensionTask = Task.Run(() => _searchIndexEngine.CountDocuments(new CounterRequest
        {
            Field = _searchIndexEngine.GetFieldName(x => x.Extension)
        }));
        var totalHiResFilesTask = Task.Run(() => _searchIndexEngine.Search(new SearchRequest
        {
            Text = "hr flac",
            SearchFields = new Dictionary<string, string?> { { _searchIndexEngine.GetFieldName(x => x.Text), string.Empty } },
            QueryType = QueryTypesEnum.Text,
            Pagination = new PaginationRequest(int.MaxValue, 0)
        }));
        var releaseYearsTask = Task.Run(() => _searchIndexEngine.CountDocuments(new CounterRequest
        {
            Field = _searchIndexEngine.GetFieldName(x => x.Year),
            IsNumeric = true
        }));
        var genreCountTask = Task.Run(() => _searchIndexEngine.CountDocuments(new CounterRequest
        {
            Field = _searchIndexEngine.GetFieldName(x => x.Genre)
        }));
        var latestAdditionsTask = Task.Run(() => _searchIndexEngine.GetLatestAddedItems(new CounterRequest
        {
            Field = _searchIndexEngine.GetFieldName(x => x.Release),
            AdditionalField = _searchIndexEngine.GetFieldName(x => x.Artist),
            SortByField = _searchIndexEngine.GetFieldName(x => x.ModifiedDate),
            IsNumeric = false,
            Top = 50
        }));

        Task.WhenAll(
            totalFilesTask,
            totalFilesByExtensionTask,
            totalHiResFilesTask,
            releaseYearsTask,
            genreCountTask,
            latestAdditionsTask)
            .GetAwaiter()
            .GetResult();

        return new IndexCounts
        {
            TotalFiles = totalFilesTask.Result.First().Value,
            TotalFilesByExtension = totalFilesByExtensionTask.Result,
            TotalHiResFiles = totalHiResFilesTask.Result.TotalHits,
            ReleaseYears = releaseYearsTask.Result,
            GenreCount = genreCountTask.Result,
            LatestAdditions = latestAdditionsTask.Result
        };
    }

    private SearchResultDto<MusicLibraryDocument> PerformSearch(
        string query,
        string[]? terms,
        string[] fields,
        QueryTypesEnum queryType,
        IDictionary<string, IEnumerable<string?>?>? facets = null)
    {
        if (string.IsNullOrEmpty(query) && (terms == null || terms.Length == 0))
            return SearchResultDto<MusicLibraryDocument>.Empty();

        if (fields == null || fields.Length == 0)
            return SearchResultDto<MusicLibraryDocument>.Empty();

        var searchFields = new Dictionary<string, string?>(fields.Length);

        for (var i = 0; i < fields.Length; i++)
            searchFields.Add(fields[i], terms is not null && i < terms.Length ? terms[i] : string.Empty);

        var searchRequest = new SearchRequest
        {
            Text = query,
            SearchFields = searchFields,
            QueryType = queryType,
            Pagination = new PaginationRequest(int.MaxValue, 0),
            Facets = facets,
            SearchType = SearchType.ExactMatch
        };

        return _searchIndexEngine.Search(searchRequest);
    }
}
