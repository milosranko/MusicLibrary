using MusicLibrary.Indexer.Models.Base;
using System;

namespace MusicLibrary.Indexer.Helpers;

public static class DocumentModelHelpers
{
    public static string GetFieldName<T>(Func<T, string> field) where T : IDocument
    {
        //field.Method.ContainsGenericParameters
        //var searchableAttr = field..GetCustomAttribute<SearchableAttribute>();
        return "";
    }
}
