using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Business.Models;
using MusicLibrary.Common;
using MusicLibrary.Indexer.Engine;
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
    private readonly ISearchIndexEngine<MusicLibraryDocument> _engine;
    private readonly CancellationToken _ct;
    private readonly object _locker = new();
    private string _drive = string.Empty;

    public FileIndexer(CancellationToken ct)
    {
        _engine = new GenericSearchIndexEngine<MusicLibraryDocument>();
        _ct = ct;
    }

    public void StartIndexing(
        IEnumerable<string> fileList,
        IProgress<ProgressArgs> progress,
        bool onlyNewFiles = false)
    {
        if (!fileList.Any())
            return;

        if (onlyNewFiles)
            fileList = _engine.SkipExistingDocuments(fileList.Select(RemoveDriveInfo).ToArray());

        var contents = new ConcurrentBag<MusicLibraryDocument>();
        var progressArgs = new ProgressArgs { TotalFiles = fileList.Count() };

        Parallel.ForEach(fileList, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = _ct }, file =>
        {
            var track = new Track(file);
            var metaTags = track.GetMetaTags();

            contents.Add(new MusicLibraryDocument
            {
                FileId = RemoveDriveInfo(file),
                Drive = GetOrSetDriveInfo(file),
                FileName = Path.GetFileName(file),
                Extension = Path.GetExtension(file).Remove(0, 1).ToLower(),
                ModifiedDate = track.GetModifiedDate(),
                Tags = metaTags,
                Text = GetContentText(file, metaTags),
                Artist = string.IsNullOrEmpty(track.Artist.Trim()) ? "Unknown" : track.Artist.Trim(),
                Release = string.IsNullOrEmpty(track.Album.Trim()) ? "Unknown" : track.Album.Trim(),
                Genre = string.IsNullOrEmpty(track.Genre.Trim()) ? "Unknown" : track.Genre.Trim(),
                Year = track.Year ?? 0
            });

            progressArgs.FilesProcessed = contents.Count;
            progress.Report(progressArgs);
        });

        if (!contents.IsEmpty)
        {
            progress.Report(new ProgressArgs { Message = "committing index changes..." });
            _engine.AddOrUpdateDocuments(contents, _ct);
            contents.Clear();
        }
    }

    public void ClearIndex()
    {
        _engine.DeleteAll();
    }

    public void RemoveFromIndex(string[] ids)
    {
        _engine.DeleteById(ids);
    }

    public Task Optimize()
    {
        var filesToRemoveFromIndex = new ConcurrentBag<string>();
        var ids = _engine.GetAllIndexedIds();

        Parallel.ForEach(ids, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = _ct }, file =>
        {
            if (!File.Exists(file))
                filesToRemoveFromIndex.Add(file);
        });

        _engine.DeleteById(filesToRemoveFromIndex.ToArray());

        return Task.CompletedTask;
    }

    public async Task<(bool Success, string FileName)> ShareIndex()
    {
        if (_engine.IndexNotExistsOrEmpty())
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
            if (string.IsNullOrEmpty(_drive))
                _drive = path[..2];

        return _drive;
    }
}
