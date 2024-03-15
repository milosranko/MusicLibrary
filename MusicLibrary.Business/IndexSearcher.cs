using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Helpers;
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
    private readonly ISearchIndexEngine<Content> _searchIndexEngine;
    public IEnumerable<string> SharedIndexes;

    public IndexSearcher()
    {
        SharedIndexes = GetSharedIndexes();
        _searchIndexEngine = new GenericSearchIndexEngine<Content>();
    }

    public IndexSearcher(string indexName)
    {
        _searchIndexEngine = new GenericSearchIndexEngine<Content>();
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
            .Select(x => x.Split(Path.DirectorySeparatorChar).Last());
    }

    public Task<SearchResult<Content>> Search(string query, string[]? terms, SearchFieldsEnum searchField)
    {
        return searchField switch
        {
            SearchFieldsEnum.Text => Search(
                query.RemoveSpecialCharacters().ToLower(),
                terms,
                [nameof(Content.Text)],
                QueryTypesEnum.Text),
            SearchFieldsEnum.Genre => Search(
                query,
                [query],
                [nameof(Content.Genre)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(Content.Artist), [] }, { nameof(Content.Album), [] } }),
            SearchFieldsEnum.Year => Search(
                query,
                [query],
                [nameof(Content.Year)],
                QueryTypesEnum.Numeric,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(Content.Artist), [] }, { nameof(Content.Album), [] } }),
            SearchFieldsEnum.Extension => Search(
                query,
                [query],
                [nameof(Content.Extension)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(Content.Extension), [] } }),
            SearchFieldsEnum.Release => Search(
                query,
                terms,
                [nameof(Content.Artist), nameof(Content.Album)],
                QueryTypesEnum.MultiTerm,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(Content.Year), [] } }),
            SearchFieldsEnum.Artist => Search(
                query,
                [query],
                [nameof(Content.Artist)],
                QueryTypesEnum.Term,
                new Dictionary<string, IEnumerable<string?>?> { { nameof(Content.Artist), [query] }, { nameof(Content.Album), [] } }),
            _ => Search(
                query.RemoveSpecialCharacters().ToLower(),
                terms,
                [nameof(Content.Text)],
                QueryTypesEnum.Text),
        };
    }

    public IEnumerable<Content> GetSearchResultByIds(string[] ids)
    {
        if (_searchIndexEngine.IndexNotExistsOrEmpty())
            return [];

        return _searchIndexEngine.GetByIds(ids);
    }

    public Task<IndexCounts> GetIndexCounts()
    {
        if (_searchIndexEngine.IndexNotExistsOrEmpty())
            return Task.FromResult(IndexCounts.Empty);

        return Task.FromResult(_searchIndexEngine.GetIndexStatistics());
    }

    private Task<SearchResult<Content>> Search(
        string query,
        string[]? terms,
        string[] fields,
        QueryTypesEnum queryType,
        Dictionary<string, IEnumerable<string?>?>? facets = null)
    {
        if (string.IsNullOrEmpty(query) && (terms == null || terms.Length == 0))
            return Task.FromResult(SearchResult<Content>.Empty());

        if (fields == null || fields.Length == 0)
            return Task.FromResult(SearchResult<Content>.Empty());

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
