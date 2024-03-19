﻿using MusicLibrary.Indexer.Models.Enums;
using System.Collections.Generic;

namespace MusicLibrary.Indexer.Models;

public struct SearchRequest
{
    public string? Text { get; set; }
    public Pagination Pagination { get; set; }
    public QueryTypesEnum QueryType { get; set; }
    public IDictionary<string, string?>? SearchFields { get; set; }
    public SearchType SearchType { get; set; }
    public IDictionary<string, IEnumerable<string?>?>? Facets { get; set; }
}
