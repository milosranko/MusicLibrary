using MusicLibrary.Indexer.Models.Enums;

namespace MusicLibrary.Indexer.Models;

public struct CounterRequest
{
    public Pagination Pagination { get; set; }
    public QueryTypesEnum QueryType { get; set; }
    public string Field { get; set; }
    public bool IsNumeric { get; set; }
}
