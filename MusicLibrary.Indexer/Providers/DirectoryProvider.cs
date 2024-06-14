using Lucene.Net.Store;
using Lucene.Net.Store.Azure;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Enums;
using Directory = Lucene.Net.Store.Directory;

namespace MusicLibrary.Indexer.Providers;

internal static class DirectoryProvider
{
    private const string FACETS_INDEX_FOLDER_SUFFIX = "taxo";

    public static Directory CreateDocumentIndex(IndexOptions options)
    {
        switch (options.StorageType)
        {
            case IndexDirectory.FileSystem:
                var path = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData,
                    Environment.SpecialFolderOption.Create), options.IndexDirectory);

                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);

                return FSDirectory.Open(path);
            case IndexDirectory.Memory:
                return new RAMDirectory();
            case IndexDirectory.Azure:
                return new AzureDirectory(options.AzureStorageCredentials, options.IndexDirectory);
            default:
                return new RAMDirectory();
        }
    }

    public static Directory CreateFacetIndex(IndexOptions options)
    {
        switch (options.StorageType)
        {
            case IndexDirectory.FileSystem:
                var path = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData,
                    Environment.SpecialFolderOption.Create), $"{options.IndexDirectory}-{FACETS_INDEX_FOLDER_SUFFIX}");

                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);

                return FSDirectory.Open(path);
            case IndexDirectory.Memory:
                return new RAMDirectory();
            case IndexDirectory.Azure:
                return new AzureDirectory(options.AzureStorageCredentials, $"{options.IndexDirectory}-{FACETS_INDEX_FOLDER_SUFFIX}");
            default:
                return new RAMDirectory();
        }
    }
}
