using MusicLibrary.Indexer.Models.Base;
using System.Collections.Generic;

namespace MusicLibrary.Indexer.Models.Internal;

internal static class DocumentFields<T> where T : IDocument
{
    private static IDictionary<string, FieldProperties> _fields { get; set; }

    public static IDictionary<string, FieldProperties> Fields => _fields;
    public static void SetFields(IDictionary<string, FieldProperties> fields)
    {
        _fields = fields;
    }
}
