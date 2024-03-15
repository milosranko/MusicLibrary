using Lucene.Net.Index;
using MusicLibrary.Indexer.Models.Base;
using System;
using System.Collections.Generic;

namespace MusicLibrary.Indexer.Engine;

public interface IDocumentWriter<T> : IDisposable where T : MappingDocumentBase<T>, IDocument
{
    void Add(T document);
    void AddRange(IEnumerable<T> documents);
    void Update(T document);
    void Delete(T document);
    void DeleteAll();
    void DeleteById(string[] ids);
    void Commit();
    void Init();
    DirectoryReader GetDirectoryReader();
}
