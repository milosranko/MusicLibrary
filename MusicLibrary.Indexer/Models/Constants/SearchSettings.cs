using System;

namespace MusicLibrary.Indexer.Models.Constants
{
    internal static class SearchSettings
    {
        public const string IndexLocation = @"C:\Temp\Index";
        public static string LocalAppData => 
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData, 
                Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Index";
    }
}
