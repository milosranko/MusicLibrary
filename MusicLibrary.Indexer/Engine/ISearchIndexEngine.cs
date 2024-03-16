using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace MusicLibrary.Indexer.Engine;

public interface ISearchIndexEngine<T> where T : IDocument
{
    void AddOrUpdateDocuments(ConcurrentBag<T> contents, CancellationToken ct = default);
    IEnumerable<T> GetByIds(string[] ids);
    void DeleteAll();
    void DeleteById(string[] ids);
    bool IndexNotExistsOrEmpty();
    IEnumerable<string> SkipExistingDocuments(string[] ids);
    SearchResult<T> Search(SearchRequest request);
    IDictionary<string, int> CountDocuments(SearchRequest? request);
}
