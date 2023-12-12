using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Indexer.Models;

public struct SearchResult
{
	public static SearchResult Empty()
	{
		return new()
		{
			Hits = Enumerable.Empty<SearchHit>(),
			SearchText = string.Empty,
			TotalHits = 0,
			Pagination = new Pagination(0, 0)
		};
	}

	public string SearchText { get; set; }
	public int TotalHits { get; set; }
	public IEnumerable<SearchHit> Hits { get; set; }
	public bool HasHits => Hits != null && Hits.Any();
	public Pagination Pagination { get; set; }
}
