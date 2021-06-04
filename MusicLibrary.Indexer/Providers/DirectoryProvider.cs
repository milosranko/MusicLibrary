using Lucene.Net.Store;
using MusicLibrary.Indexer.Models.Constants;
using Directory = Lucene.Net.Store.Directory;

namespace MusicLibrary.Indexer.Providers
{
    internal static class DirectoryProvider
    {
        public static Directory CreateDocumentIndex()
        {
            if (!System.IO.Directory.Exists(SearchSettings.LocalAppData))
                System.IO.Directory.CreateDirectory(SearchSettings.LocalAppData);
            
            return FSDirectory.Open(SearchSettings.LocalAppData);
        }
    }
}
