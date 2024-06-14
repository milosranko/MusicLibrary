using MusicLibrary.Indexer.Models.Enums;

namespace MusicLibrary.Indexer.Models;

public record IndexOptions
{
    public IndexDirectory StorageType { get; set; }
    public string IndexDirectory { get; set; }
    public string AzureStorageCredentials { get; set; }
    public DefaultAnalyzer DefaultAnalyzer { get; set; }
}
