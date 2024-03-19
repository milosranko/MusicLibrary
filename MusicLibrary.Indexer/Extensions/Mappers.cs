using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Dto;
using MusicLibrary.Indexer.Models.Internal;
using System.Linq;

namespace MusicLibrary.Indexer.Extensions;

internal static class Mappers
{
    public static SearchResultDto<T> ToDto<T>(this SearchResult searchResult) where T : MappingDocumentBase<T>, IDocument, new()
    {
        return new SearchResultDto<T>
        {
            TotalHits = searchResult.TotalHits,
            Pagination = searchResult.Pagination,
            Facets = searchResult.Facets,
            Hits = searchResult.Hits.Select(x => new T().MapFromLuceneDocument(x))
        };
    }
}
