namespace MusicLibrary.Indexer.Queries;

public class FieldsSearchQuery : SearchQueryBase
{
    public IDictionary<string, string?>? SearchFields { get; set; } = new Dictionary<string, string?>();
}
