namespace MusicLibrary.Indexer.Models.Facets;

public record FacetFilter
{
    public string Name { get; set; }
    public IEnumerable<FacetValue>? Values { get; set; }
}
