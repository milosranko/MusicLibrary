using System.Collections.Generic;

namespace MusicLibrary.Indexer.Facets;

public class FacetFilter
{
    public string Name { get; set; }
    public IEnumerable<FacetValue>? Values { get; set; }
}
