using Lucene.Net.Store;
using MusicLibrary.Common;
using System.IO;
using Directory = Lucene.Net.Store.Directory;

namespace MusicLibrary.Indexer.Providers
{
    internal static class DirectoryProvider
    {
        public static Directory CreateDocumentIndex()
        {
            if (!System.IO.Directory.Exists(Constants.LocalAppDataIndex))
                System.IO.Directory.CreateDirectory(Constants.LocalAppDataIndex);
            
            return FSDirectory.Open(Constants.LocalAppDataIndex);
        }

        public static Directory GetDocumentIndex(string indexName)
        {
            var path = Path.Combine(Constants.LocalAppDataShares, indexName);

            if (!System.IO.Directory.Exists(path))
                return null;

            return FSDirectory.Open(path);
        }
    }
}
