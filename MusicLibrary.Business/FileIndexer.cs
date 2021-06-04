using ATL;
using MusicLibrary.Business.Extensions;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Business
{
    public class FileIndexer
    {
        private readonly CancellationToken _ct;
        private readonly SearchIndexEngine _engine;

        public FileIndexer(CancellationToken ct)
        {
            _ct = ct;
            _engine = new SearchIndexEngine();
        }

        public void StartIndexing(IEnumerable<string> fileList, Action<int> statusProgress, bool onlyNewFiles = false)
        {
            if (!fileList.Any()) return;

            if (onlyNewFiles)
            {
                fileList = _engine.DocumentsExists(fileList);
            }

            var contents = new ConcurrentBag<Content>();

            Parallel.ForEach(fileList, new ParallelOptions { CancellationToken = _ct }, file =>
            {
                try
                {
                    statusProgress?.Invoke(contents.Count);
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
                        Year = track.Year
                    });
                }
                catch (Exception)
                {
                    //TODO create a list of files that has a problem
                }
            });

            if (!contents.IsEmpty)
            {
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

            Parallel.ForEach(ids, new ParallelOptions { CancellationToken = _ct }, file =>
            {
                if (!File.Exists(file)) filesToRemoveFromIndex.Add(file);
            });

            _engine.DeleteById(filesToRemoveFromIndex.ToArray());

            return Task.CompletedTask;
        }

        private string GetContentText(string file, string[] tags)
        {
            var sb = new StringBuilder();

            sb.AppendLine(file.Remove(0, 3).Replace("\\", " ").Replace(".", " "));
            sb.AppendLine(string.Join(" ", tags));
            
            return ContentHelpers.CleanContent(sb);
        }
    }
}
