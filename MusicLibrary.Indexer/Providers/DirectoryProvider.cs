using Lucene.Net.Store;
using MusicLibrary.Common;
using System;
using Directory = Lucene.Net.Store.Directory;

namespace MusicLibrary.Indexer.Providers;

internal static class DirectoryProvider
{
    public static Directory GetOrCreateDocumentIndex(string? indexName)
    {
        FSDirectory directory;

        if (string.IsNullOrEmpty(indexName))
        {
            if (!System.IO.Directory.Exists(Constants.LocalAppDataIndex))
                System.IO.Directory.CreateDirectory(Constants.LocalAppDataIndex);

            directory = FSDirectory.Open(Constants.LocalAppDataIndex);
        }
        else
        {
            var path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData,
                Environment.SpecialFolderOption.Create) + $"\\MusicLibrary\\index\\{indexName}";

            directory = FSDirectory.Open(path);
        }

        //using var analyzer = new WhitespaceAnalyzer(Lucene.Net.Util.LuceneVersion.LUCENE_48);
        //using var writer = new IndexWriter(directory, new IndexWriterConfig(Lucene.Net.Util.LuceneVersion.LUCENE_48, analyzer));
        //writer.DeleteUnusedFiles();

        return directory;
    }

    public static Directory GetOrCreateTaxoIndex()
    {
        if (!System.IO.Directory.Exists(Constants.LocalAppDataTaxoIndex))
            System.IO.Directory.CreateDirectory(Constants.LocalAppDataTaxoIndex);

        return FSDirectory.Open(Constants.LocalAppDataTaxoIndex);

        //using var analyzer = new WhitespaceAnalyzer(Lucene.Net.Util.LuceneVersion.LUCENE_48);
        //using var writer = new IndexWriter(directory, new IndexWriterConfig(Lucene.Net.Util.LuceneVersion.LUCENE_48, analyzer));
        //writer.DeleteUnusedFiles();
    }
}
