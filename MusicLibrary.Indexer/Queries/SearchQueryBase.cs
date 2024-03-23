﻿using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Enums;

namespace MusicLibrary.Indexer.Queries;

public abstract class SearchQueryBase
{
    public PaginationRequest Pagination { get; set; }
    public QueryTypesEnum QueryType { get; set; }
    public SearchType SearchType { get; set; }
    public IDictionary<string, IEnumerable<string?>?>? Facets { get; set; }
}
