namespace MusicLibrary.Common.Helpers
{
    public static class MetatagsHelpers
    {
        public static string[] GetMetatags(string value)
        {
            return value.Split("|");
        }

        public static string CreateMetatags(string artist, string release, string year, string genre, string title, string trackNo)
        {
            return string.Join("|", artist, release, year, genre, title, trackNo);
        }
    }
}
