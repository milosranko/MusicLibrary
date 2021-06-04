using MetaBrainz.MusicBrainz;
using MusicLibrary.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Business
{
    public class MusicBrainzService
    {
        private readonly Query _query;
        private const string ClientId = "CMSoPUdKEi0aut9XTQJbdDgAqXxUfMri";
        private const string ClientSecret = "QhEhv_VZ6RBHLr2e4Rz7U4qSw8vWcjuN";

        public MusicBrainzService()
        {
            _query = new Query("MusicLibrary", "1.0.0", "mailto:milos.ranko@gmail.com");
        }

        public async Task<string> Authenticate()
        {
            var oa = new OAuth2
            {
                ClientId = ClientId,
            };
            var url = oa.CreateAuthorizationRequest(OAuth2.OutOfBandUri, AuthorizationScope.Rating | AuthorizationScope.Tag);
            var at = await oa.GetBearerTokenAsync("code", ClientSecret, OAuth2.OutOfBandUri);

            return at.AccessToken;
        }

        public async Task<IEnumerable<MusicBrainzSearchResult>> Search(string artist, string release, string year)
        {
            if (string.IsNullOrWhiteSpace(artist) && string.IsNullOrWhiteSpace(release) && string.IsNullOrWhiteSpace(year))
                return Enumerable.Empty<MusicBrainzSearchResult>();

            var sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(artist)) sb.Append($"artist:{artist} ");
            if (sb.Length > 0 && !string.IsNullOrWhiteSpace(release)) sb.Append($"AND ");
            if (!string.IsNullOrWhiteSpace(release)) sb.Append($"release:{release} ");
            if (sb.Length > 0 && !string.IsNullOrWhiteSpace(year)) sb.Append("AND ");
            if (!string.IsNullOrWhiteSpace(year)) sb.Append($"date:{year}");

            try
            {
                var res = await _query.FindReleasesAsync(sb.ToString(), 10);

                if (res == null || res.TotalResults == 0) return Enumerable.Empty<MusicBrainzSearchResult>();

                var searchRes = new List<MusicBrainzSearchResult>(res.Results.Count);

                foreach (var item in res.Results)
                {
                    searchRes.Add(new MusicBrainzSearchResult
                    {
                        Id = item.Item.Id,
                        Artist = item.Item.ArtistCredit.FirstOrDefault()?.Artist.Name,
                        Release = item.Item.Title,
                        NumberOfTracks = item.Item.Media.Count > 0 ? item.Item.Media[0].TrackCount : 0,
                        Year = item.Item.Date?.Year?.ToString()
                    });
                }

                return searchRes;
            }
            catch
            {
                return Enumerable.Empty<MusicBrainzSearchResult>();
            }
        }

        public async Task<MusicBrainzSearchResult> GetTracks(MusicBrainzSearchResult release)
        {
            if (release.Equals(MusicBrainzSearchResult.Empty)) throw new ArgumentException("Id is empty!");
            if (release.Id == Guid.Empty) throw new ArgumentException("Id is empty!");

            try
            {
                var res = await _query.LookupReleaseAsync(release.Id, Include.Genres | Include.Media | Include.Recordings);

                if (res == null || !res.Media.Any()) return MusicBrainzSearchResult.Empty;

                release.Genre = res.Media[0].Tracks?[0].Recording.Genres?.FirstOrDefault()?.Name;
                release.Tracks = res.Media[0].Tracks?.Count > 0 ? res.Media[0].Tracks.Select(x => x.Title) : Enumerable.Empty<string>();

                return release;
            }
            catch
            {
                return release;
            }
        }
    }
}
