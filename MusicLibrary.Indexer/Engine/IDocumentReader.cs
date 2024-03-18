using Lucene.Net.Index;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using System;
using System.Collections.Generic;

namespace MusicLibrary.Indexer.Engine;

public interface IDocumentReader<T> : IDisposable where T : IDocument
{
    IEnumerable<T> GetByIds(string[] ids);
    bool DocumentExists(string id);
    bool IndexNotExistsOrEmpty();
    SearchResult<T> Search(SearchRequest request);
    void Init();
    void Init(DirectoryReader reader);
    DirectoryReader? Reader { get; }
    IDictionary<string, int> TermsCounter(string field, bool isNumeric = false);
}
