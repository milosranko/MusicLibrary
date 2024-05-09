namespace MusicLibrary.Indexer.Models.Facets;

public record FacetValue
{
    public string? Value { get; set; }
    public int Count { get; set; }
}
