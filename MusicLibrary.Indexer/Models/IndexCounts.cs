﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Indexer.Models
{
    public struct IndexCounts
    {
        public static IndexCounts Empty =>
            new IndexCounts
            {
                TotalFiles = default(int),
                TotalFilesByExtension = new Dictionary<string, int>(),
                GenreCount = new Dictionary<string, int>(),
                ReleaseYears = new Dictionary<string, int>(),
                LatestAdditions = Enumerable.Empty<ValueTuple<string, string>>()
            };

        public int TotalFiles { get; set; }
        public IDictionary<string, int> TotalFilesByExtension { get; set; }
        public IDictionary<string, int> GenreCount { get; set; }
        public IDictionary<string, int> ReleaseYears { get; set; }
        public IEnumerable<ValueTuple<string, string>> LatestAdditions { get; set; }
    }
}
