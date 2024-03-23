using MusicLibrary.Common;

namespace MusicLibrary.Business;

public class FileScanner
{
    public static IEnumerable<string> ScanForMusicFiles(
        string root,
        IProgress<ProgressArgs> progress,
        CancellationToken ct)
    {
        if (string.IsNullOrEmpty(root)) return [];
        if (!Directory.Exists(root)) return [];

        var output = new List<string>();
        var options = new EnumerationOptions
        {
            IgnoreInaccessible = true,
            MatchCasing = MatchCasing.CaseInsensitive,
            MatchType = MatchType.Simple,
            RecurseSubdirectories = true
        };

        output.AddRange(Directory.EnumerateFiles(root, "*", SearchOption.TopDirectoryOnly));
        var progressArgs = new ProgressArgs();

        foreach (var folder in Directory.EnumerateDirectories(root, "*", options))
        {
            if (ct.IsCancellationRequested) break;

            progressArgs.Folder = folder;
            progress.Report(progressArgs);
            output.AddRange(Directory.EnumerateFiles(folder, "*", SearchOption.TopDirectoryOnly));
        }

        return output
            .Where(x => Path.GetExtension(x).EndsWith(Constants.MusicFileExtensions[0]) ||
                        Path.GetExtension(x).EndsWith(Constants.MusicFileExtensions[1]));
    }
}
