using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Common;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Business;

public class FileIndexer
{
    private readonly CancellationToken _ct;
    private readonly object _locker = new();
    private string _drive = string.Empty;

    public FileIndexer(CancellationToken ct)
    {
        _ct = ct;
    }

    public async void StartIndexing(
        IEnumerable<string> fileList,
        IProgress<ProgressArgs> progress,
        bool onlyNewFiles = false)
    {
        if (!fileList.Any())
            return;

        using var engine = new SearchIndexEngine();

        if (onlyNewFiles)
            fileList = engine.DocumentsExists(fileList);

        var contents = new ConcurrentBag<Content>();
        var progressArgs = new ProgressArgs();

        Parallel.ForEach(fileList, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = _ct }, file =>
        {
            try
            {
                progressArgs.Files = contents.Count;
                progress.Report(progressArgs);
                var track = new Track(file);
                var metaTags = track.GetMetaTags();

                contents.Add(new Content
                {
                    FileId = file,
                    FileName = Path.GetFileName(file),
                    Extension = Path.GetExtension(file).Remove(0, 1).ToLower(),
                    ModifiedDate = track.GetModifiedDate(),
                    Tags = metaTags,
                    Text = GetContentText(file, metaTags),
                    Artist = track.Artist,
                    Album = track.Album,
                    Genre = track.Genre,
                    Year = track.Year ?? 0
                });
            }
            catch (Exception e)
            {
                throw new Exception($"Error occured on file: {file}", e);
            }
        });

        if (!contents.IsEmpty)
        {
            await Task.Run(() => engine.AddOrUpdateDocuments(contents, _ct));
            contents.Clear();
        }
    }

    public void ClearIndex()
    {
        using var engine = new SearchIndexEngine();
        engine.DeleteAll();
    }

    public void RemoveFromIndex(string[] ids)
    {
        using var engine = new SearchIndexEngine();
        engine.DeleteById(ids);
    }

    public Task Optimize()
    {
        using var engine = new SearchIndexEngine();
        var filesToRemoveFromIndex = new ConcurrentBag<string>();
        var ids = engine.GetAllIndexedIds();

        Parallel.ForEach(ids, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount - 1, CancellationToken = _ct }, file =>
        {
            if (!File.Exists(file))
                filesToRemoveFromIndex.Add(file);
        });

        engine.DeleteById(filesToRemoveFromIndex.ToArray());

        return Task.CompletedTask;
    }

    public async Task<(bool Success, string FileName)> ShareIndex()
    {
        using var engine = new SearchIndexEngine();

        if (engine.IndexNotExistsOrEmpty())
            return (false, string.Empty);

        if (!Directory.Exists(Constants.LocalAppDataShares))
            Directory.CreateDirectory(Constants.LocalAppDataShares);

        var fileName = $"{Environment.MachineName}_{Environment.UserName}.mla".ToLower();
        var path = $"{Constants.LocalAppDataShares}\\{fileName}";

        if (File.Exists(path))
            File.Delete(path);

        await Task.Run(() => ZipFile.CreateFromDirectory(Constants.LocalAppDataIndex, path, CompressionLevel.SmallestSize, false, Encoding.ASCII));

        return (true, fileName);
    }

    private string GetContentText(string file, string[] tags)
    {
        var sb = new StringBuilder();

        sb.AppendLine(file.Remove(0, 3).Replace("\\", " ").Replace(".", " "));
        sb.AppendLine(string.Join(" ", tags));

        return ContentHelpers.CleanContent(sb);
    }

    private string RemoveDriveInfo(string path)
    {
        return path.Remove(0, 2);
    }

    private string GetOrSetDriveInfo(string path)
    {
        if (!string.IsNullOrEmpty(_drive))
            return _drive;

        lock (_locker)
        {
            if (string.IsNullOrEmpty(_drive))
                _drive = path[..2];
        }

        return _drive;
    }
}
