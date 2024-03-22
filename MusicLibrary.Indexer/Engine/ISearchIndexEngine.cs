using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Dto;
using System.Collections.Generic;
using System.Threading;

namespace MusicLibrary.Indexer.Engine;

public interface ISearchIndexEngine<T> where T : IDocument
{
    void AddOrUpdateDocuments(IEnumerable<T> contents, CancellationToken ct = default);
    IEnumerable<T> GetByIds(string[] ids);
    void DeleteAll();
    void DeleteById(string[] ids);
    bool IndexNotExistsOrEmpty();
    IEnumerable<string> SkipExistingDocuments(string[] ids);
    SearchResultDto<T> Search(SearchRequest request);
    IDictionary<string, int> CountDocuments(CounterRequest? request);
    IDictionary<string, string> GetLatestAddedItems(CounterRequest request);
    IEnumerable<string> GetAllIndexedIds();
}
