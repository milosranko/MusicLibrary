using System;

namespace MusicLibrary.Indexer.Models.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class IndexConfigAttribute : Attribute
{
    public string IndexName { get; set; }
}
