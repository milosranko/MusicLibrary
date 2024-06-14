using MusicLibrary.Business;
using MusicLibrary.Common;
using System.Collections.Concurrent;

namespace MusicLibrary.Tests;

[TestClass]
public class FileIndexerTests
{
    private static string _filesPath = $"{Environment.CurrentDirectory}\\Resources";
    private FileIndexer _fileIndexer;
    private IndexSearcher _indexSearcher;
    private CancellationTokenSource _cancellationTokenSource;
    private IEnumerable<string> _files;

    public FileIndexerTests()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        _files = Directory.EnumerateFiles(_filesPath, "*", SearchOption.TopDirectoryOnly);
        _fileIndexer = new FileIndexer(Globals.IndexOptions, _cancellationTokenSource.Token);
    }

    [ClassInitialize]
    public static void Initialize(TestContext context)
    {
    }

    [TestMethod]
    public void WriteIndexTest_ShouldCreateIndexFolderAndFiles()
    {
        //Arrange        
        var processedFiles = new ConcurrentBag<int>();
        var progress = new Progress<ProgressArgs>(x => processedFiles.Add(x.FilesProcessed));
        _indexSearcher = new IndexSearcher(Globals.IndexOptions);

        //Act
        _fileIndexer.StartIndexing(_files, progress);

        //Assert
        var counts = _indexSearcher.GetIndexCounts();
        Assert.IsFalse(processedFiles.IsEmpty);
        Assert.IsNotNull(counts);
        Assert.IsTrue(counts.TotalFiles > 0);
    }

    [TestMethod]
    public void WriteIndexTest_ShouldIndexOnlyNewFiles()
    {
        //Arrange        
        var processedFiles = new ConcurrentBag<int>();
        var progress = new Progress<ProgressArgs>(x => processedFiles.Add(x.FilesProcessed));

        //Act
        _fileIndexer.StartIndexing(_files, progress, true);

        //Assert
        Assert.IsTrue(processedFiles.IsEmpty);
    }

    [TestMethod]
    [ExpectedException(typeof(OperationCanceledException))]
    public void WriteIndexTest_CancelExecution()
    {
        //Arrange        
        var processedFiles = new ConcurrentBag<int>();
        var progress = new Progress<ProgressArgs>(x => processedFiles.Add(x.FilesProcessed));

        //Act
        _cancellationTokenSource.Cancel();
        _fileIndexer.StartIndexing(_files, progress);

        //Assert
        Assert.IsTrue(processedFiles.IsEmpty);
    }
}