namespace MusicLibrary.Common.Extensions;

public static class StringExtensions
{
    public static string RemoveDriveInfo(this string path)
    {
        return path.Remove(0, 2);
    }
}
