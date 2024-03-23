using Lucene.Net.Documents;
using MusicLibrary.Indexer.Models.Dto;
using MusicLibrary.Indexer.Models.Facets;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Indexer.Models.Internal;

internal struct SearchResult
{
    public static SearchResult Empty => new()
    {
        Hits = [],
        SearchText = string.Empty,
        TotalHits = 0,
        Pagination = new PaginationDto(0, 0, 0)
    };

    public string SearchText { get; set; }
    public int TotalHits { get; set; }
    public IEnumerable<Document> Hits { get; set; }
    public readonly bool HasHits => Hits != null && Hits.Any();
    public PaginationDto Pagination { get; set; }
    public IEnumerable<FacetFilter> Facets { get; set; }
}
