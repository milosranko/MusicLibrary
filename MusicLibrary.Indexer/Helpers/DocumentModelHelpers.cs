using Lucene.Net.Facet;
using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Internal;
using System.Reflection;

namespace MusicLibrary.Indexer.Helpers;

internal static class DocumentModelHelpers<T> where T : IDocument
{
    public static void ReflectDocumentFields()
    {
        if (!string.IsNullOrEmpty(DocumentFields<T>.IndexName) && DocumentFields<T>.Fields.Any())
            return;

        var indexName = typeof(T).GetCustomAttribute<IndexConfigAttribute>()?.IndexName ?? "index";
        var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
        var fields = new Dictionary<string, FieldProperties>(props.Length);
        var facetsConfig = new FacetsConfig();
        SearchableAttribute? searchableAttr;
        FacetPropertyAttribute? facetAttr;
        MultiValueFacetPropertyAttribute? multiValueFacetAttr;

        foreach (var prop in props)
        {
            searchableAttr = prop.GetCustomAttribute<SearchableAttribute>();
            facetAttr = prop.GetCustomAttribute<FacetPropertyAttribute>();
            multiValueFacetAttr = prop.GetCustomAttribute<MultiValueFacetPropertyAttribute>();

            if (searchableAttr is null) continue;

            var fieldName = GetFieldName(searchableAttr, prop);

            fields.Add(prop.Name, new FieldProperties
            {
                FieldName = fieldName,
                FieldType = searchableAttr.FieldType,
                Stored = searchableAttr.Stored,
                IsFacet = facetAttr is not null,
                IsArray = prop.PropertyType.IsArray
            });

            if (multiValueFacetAttr is not null)
                facetsConfig.SetMultiValued(fieldName, true);
        }

        DocumentFields<T>.SetFields(indexName, fields, facetsConfig);
    }

    private static string GetFieldName(SearchableAttribute? searchableAttr, PropertyInfo prop)
    {
        return string.IsNullOrEmpty(searchableAttr?.FieldName)
            ? prop.Name
            : searchableAttr.FieldName;
    }
}
