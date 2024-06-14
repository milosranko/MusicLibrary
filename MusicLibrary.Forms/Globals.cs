using MusicLibrary.Indexer.Models;

namespace MusicLibrary.Forms;

internal static class Globals
{
    public static IndexOptions IndexOptions => new()
    {
        StorageType = Indexer.Models.Enums.IndexDirectory.FileSystem,
        IndexDirectory = "MusicLibrary\\index\\music-library",
        DefaultAnalyzer = Indexer.Models.Enums.DefaultAnalyzer.English
    };
}
