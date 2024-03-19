using System;

namespace MusicLibrary.Indexer.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class SearchableAttribute : Attribute
{
    public FieldTypeEnum FieldType { get; set; }
    public bool Stored { get; set; } = true;
    public string? FieldName { get; set; }
}

public enum FieldTypeEnum
{
    StringField,
    TextField,
    Int32Field,
    NumericDocValuesField
}
