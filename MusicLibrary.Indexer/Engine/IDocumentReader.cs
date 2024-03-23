using Lucene.Net.Documents;
using Lucene.Net.Index;
using MusicLibrary.Indexer.Models.Internal;
using MusicLibrary.Indexer.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MusicLibrary.Indexer.Engine;

internal interface IDocumentReader : IDisposable
{
    IEnumerable<Document> GetByIds(string[] ids);
    bool DocumentExists(string id);
    bool IndexNotExistsOrEmpty();
    SearchResult Search(SearchRequest request);
    void Init();
    void Init(DirectoryReader reader);
    DirectoryReader? Reader { get; }
    IDictionary<string, int> TermsCounter(string field, bool isNumeric = false);
    IDictionary<string, string> LatestAdded(string field, string additionalField, string sortBy, ListSortDirection sortDirection, int top);
}
