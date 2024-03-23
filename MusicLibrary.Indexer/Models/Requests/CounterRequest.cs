namespace MusicLibrary.Indexer.Models.Requests;

public struct CounterRequest
{
    public required string Field { get; set; }
    public string? AdditionalField { get; set; }
    public bool IsNumeric { get; set; }
    public string? SortByField { get; set; }
    public int? Top { get; set; }
}
