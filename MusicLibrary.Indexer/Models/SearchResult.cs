using MusicLibrary.Indexer.Facets;
using MusicLibrary.Indexer.Models.Base;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Indexer.Models;

public struct SearchResult<T> where T : IDocument
{
    public static SearchResult<T> Empty()
    {
        return new()
        {
            Hits = Enumerable.Empty<T>(),
            SearchText = string.Empty,
            TotalHits = 0,
            Pagination = new Pagination(0, 0)
        };
    }

    public string SearchText { get; set; }
    public int TotalHits { get; set; }
    public IEnumerable<T> Hits { get; set; }
    public readonly bool HasHits => Hits != null && Hits.Any();
    public Pagination Pagination { get; set; }
    public IEnumerable<FacetFilter> Facets { get; set; }
}
