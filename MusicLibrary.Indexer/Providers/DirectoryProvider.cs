using Lucene.Net.Analysis.Core;
using Lucene.Net.Index;
using Lucene.Net.Store;
using MusicLibrary.Common;
using System.IO;
using Directory = Lucene.Net.Store.Directory;

namespace MusicLibrary.Indexer.Providers;

internal static class DirectoryProvider
{
	public static Directory GetOrCreateDocumentIndex(string indexName)
	{
		FSDirectory directory = null;

		if (string.IsNullOrEmpty(indexName))
		{
			if (!System.IO.Directory.Exists(Constants.LocalAppDataIndex))
				System.IO.Directory.CreateDirectory(Constants.LocalAppDataIndex);

			directory = FSDirectory.Open(Constants.LocalAppDataIndex);
		}
		else
		{
			var path = Path.Combine(Constants.LocalAppDataShares, indexName);

			if (!System.IO.Directory.Exists(path))
				System.IO.Directory.CreateDirectory(path);

			directory = FSDirectory.Open(path);
		}

		using var analyzer = new WhitespaceAnalyzer(Lucene.Net.Util.LuceneVersion.LUCENE_48);
		using var writer = new IndexWriter(directory, new IndexWriterConfig(Lucene.Net.Util.LuceneVersion.LUCENE_48, analyzer));
		writer.DeleteUnusedFiles();

		return directory;
	}
}
