using System;

namespace MusicLibrary.Indexer.Models.Constants
{
    internal static class SearchSettings
    {
        public static string LocalAppData => 
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData, 
                Environment.SpecialFolderOption.Create) + "\\MusicLibrary\\Index";
    }
}
