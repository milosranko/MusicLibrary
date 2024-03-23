using Lucene.Net.Facet;
using MusicLibrary.Indexer.Models.Base;

namespace MusicLibrary.Indexer.Models.Internal;

internal static class DocumentFields<T> where T : IDocument
{
    private static string _indexName { get; set; } = string.Empty;
    private static IDictionary<string, FieldProperties> _fields { get; set; }
    private static FacetsConfig _facetsConfig { get; set; }

    public static IDictionary<string, FieldProperties> Fields => _fields;
    public static string IndexName => _indexName;
    public static FacetsConfig FacetsConfig => _facetsConfig;

    public static bool HasFacets => _fields.Any(x => x.Value.IsFacet);

    public static void SetFields(string indexName, IDictionary<string, FieldProperties> fields, FacetsConfig facetsConfig)
    {
        _indexName = indexName;
        _fields = fields;
        _facetsConfig = facetsConfig;
    }
}
