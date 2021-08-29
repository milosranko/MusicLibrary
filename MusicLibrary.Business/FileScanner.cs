using MusicLibrary.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Business
{
    public class FileScanner
    {
        public static Task<IEnumerable<string>> ScanForMusicFiles(
            string root, 
            IProgress<ProgressArgs> progress, 
            CancellationToken ct)
        {
            if (string.IsNullOrEmpty(root)) return Task.FromResult(Enumerable.Empty<string>());
            if (!Directory.Exists(root)) return Task.FromResult(Enumerable.Empty<string>());

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

            return Task.FromResult(output
                .Where(x => Path.GetExtension(x).EndsWith(Constants.MusicFileExtensions[0]) ||
                            Path.GetExtension(x).EndsWith(Constants.MusicFileExtensions[1])));
        }
    }
}
