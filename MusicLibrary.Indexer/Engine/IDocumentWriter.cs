using Lucene.Net.Documents;
using Lucene.Net.Index;

namespace MusicLibrary.Indexer.Engine;

internal interface IDocumentWriter : IDisposable
{
    void Add(Document document);
    void AddRange(IEnumerable<Document> documents);
    void Update(Document document);
    void Delete(Document document);
    void DeleteAll();
    void DeleteById(string[] ids);
    void Commit();
    void Init();
    DirectoryReader GetDirectoryReader();
}
