namespace MusicLibrary.Tests;

[TestClass]
public class TestsInitialization
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        //Prepare test data
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        //Cleanup temporary files
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Globals.IndexOptions.IndexDirectory);
        var taxoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Globals.IndexOptions.IndexDirectory + "-taxo");

        if (Directory.Exists(path))
            Directory.Delete(path, true);

        if (Directory.Exists(taxoPath))
            Directory.Delete(taxoPath, true);
    }
}
