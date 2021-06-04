using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Business.Models
{
    public struct MusicBrainzSearchResult
    {
        public static MusicBrainzSearchResult Empty => new()
        {
            Id = Guid.Empty,
            Artist = string.Empty,
            Release = string.Empty,
            Genre = string.Empty,
            Year = string.Empty,
            NumberOfTracks = 0,
            Tracks = Enumerable.Empty<string>()
        };

        public Guid Id { get; set; }
        public string Artist { get; set; }
        public string Release { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public int NumberOfTracks { get; set; }
        public IEnumerable<string> Tracks { get; set; }
    }
}
