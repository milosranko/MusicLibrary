using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    IDictionary<string, int> CountDocuments(CounterRequest? request);
    IDictionary<string, string> GetLatestAddedItems(CounterRequest request);
    IEnumerable<string> GetAllIndexedIds();
    string GetFieldName(Expression<Func<T, string>> expr);
    string GetFieldName(Expression<Func<T, int>> expr);
    string GetFieldName(Expression<Func<T, DateTime>> expr);
}
