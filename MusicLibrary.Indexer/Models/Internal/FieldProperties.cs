using MusicLibrary.Indexer.Attributes;
using System.Reflection;

namespace MusicLibrary.Indexer.Models.Internal;

internal struct FieldProperties
{
    public required string FieldName { get; set; }
    public required FieldTypeEnum FieldType { get; set; }
    public required bool Stored { get; set; }
    public required bool IsFacet { get; set; }
    public required bool IsArray { get; set; }
    public required PropertyInfo PropertyInfo { get; set; }
}
