namespace MusicLibrary.Indexer.Models.Facets;

public class FacetFilter
{
    public string Name { get; set; }
    public IEnumerable<FacetValue>? Values { get; set; }
}
