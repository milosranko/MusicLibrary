namespace MusicLibrary.Indexer.Models;

public struct CounterRequest
{
    public required string Field { get; set; }
    public bool IsNumeric { get; set; }
}
