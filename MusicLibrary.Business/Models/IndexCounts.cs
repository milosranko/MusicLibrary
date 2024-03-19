using System.Collections.Generic;

namespace MusicLibrary.Business.Models;

public struct IndexCounts
{
    public static IndexCounts Empty =>
        new()
        {
            TotalFiles = default,
            TotalFilesByExtension = new Dictionary<string, int>(),
            TotalHiResFiles = default,
            GenreCount = new Dictionary<string, int>(),
            ReleaseYears = new Dictionary<string, int>(),
            LatestAdditions = new Dictionary<string, string>()
        };

    public int? TotalFiles { get; set; }
    public IDictionary<string, int> TotalFilesByExtension { get; set; }
    public int? TotalHiResFiles { get; set; }
    public IDictionary<string, int> GenreCount { get; set; }
    public IDictionary<string, int> ReleaseYears { get; set; }
    public IDictionary<string, string> LatestAdditions { get; set; }
}
