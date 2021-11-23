using System;

namespace MusicLibrary.Common
{
    public static class Constants
    {
        public const string MultipleValues = "< keep >";
        public static readonly string[] MusicFileExtensions = { "mp3", "flac" };
        public static int[] Bitrates = new int[4] { 128, 192, 256, 320 };

        public static string LocalAppDataShares =>
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData,
                Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Shares";

        public static string LocalAppDataIndex =>
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData,
                Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Index";
    }
}
