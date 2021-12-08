using ATL;
using MusicLibrary.Common;
using System;
using System.IO;

namespace MusicLibrary.Business.Extensions
{
    public static class TrackExtensions
    {
        public static string[] GetMetaTags(this Track track)
        {
            if (track == null) return new string[7];

            var tags = new string[7];

            tags[0] = track.Artist;
            tags[1] = track.Album;
            tags[2] = track.Year.ToString();
            tags[3] = track.Genre;
            tags[4] = track.Title;
            tags[5] = track.TrackNumber.ToString();
            tags[6] = $"{track.SampleRate >= 44100 && track.Bitrate >= 1200}";

            return tags;
        }

        public static bool SetMetaTags(this Track track, string[] tags)
        {
            if (track == null || tags.Length < 6) return false;

            if (!tags[0].Equals(Constants.MultipleValues)) 
                track.Artist = tags[0];
            if (!tags[1].Equals(Constants.MultipleValues)) 
                track.Album = tags[1];
            if (!tags[2].Equals(Constants.MultipleValues) && !string.IsNullOrEmpty(tags[2])) 
                track.Year = int.Parse(tags[2]);
            if (!tags[3].Equals(Constants.MultipleValues)) 
                track.Genre = tags[3];
            if (!tags[4].Equals(Constants.MultipleValues)) 
                track.Title = tags[4];
            if (!tags[5].Equals(Constants.MultipleValues) && !string.IsNullOrEmpty(tags[5])) 
                track.TrackNumber = int.Parse(tags[5]);

            track.Comment = string.Empty;

            return track.Save();
        }

        public static DateTime GetModifiedDate(this Track track)
        {
            if (track == null) throw new FileNotFoundException();
            
            var file = new FileInfo(track.Path);

            if (file == null) throw new FileNotFoundException();

            return file.LastWriteTime;
        }
    }
}
