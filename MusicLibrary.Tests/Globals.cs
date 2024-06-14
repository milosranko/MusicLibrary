using MusicLibrary.Indexer.Models;

namespace MusicLibrary.Tests;

internal static class Globals
{
    public static IndexOptions IndexOptions => new()
    {
        StorageType = Indexer.Models.Enums.IndexDirectory.FileSystem,
        IndexDirectory = "MusicLibrary\\index-test\\music-library",
        DefaultAnalyzer = Indexer.Models.Enums.DefaultAnalyzer.English
    };
}
