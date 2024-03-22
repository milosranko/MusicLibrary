using Lucene.Net.Facet;
using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MusicLibrary.Indexer.Helpers;

internal static class DocumentModelHelpers<T> where T : IDocument
{
    public static FacetsConfig GetFacetsConfig()
    {
        var facetsConfig = new FacetsConfig();
        var facetFields = typeof(T).GetProperties()
            .Where(p => p.GetCustomAttributes().OfType<MultiValueFacetPropertyAttribute>() != null)
            .Select(p => p.Name);

        foreach (var field in facetFields)
            facetsConfig.SetMultiValued(field, true);

        return facetsConfig;
    }

    public static void ReflectDocumentFields()
    {
        var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
        var fields = new Dictionary<string, FieldProperties>(props.Length);
        SearchableAttribute? searchableAttr;
        FacetPropertyAttribute? facetAttr;

        foreach (var prop in props)
        {
            searchableAttr = prop.GetCustomAttribute<SearchableAttribute>();
            facetAttr = prop.GetCustomAttribute<FacetPropertyAttribute>();

            if (searchableAttr is null) continue;

            fields.Add(prop.Name, new FieldProperties
            {
                FieldName = string.IsNullOrEmpty(searchableAttr.FieldName) ? prop.Name : searchableAttr.FieldName,
                FieldType = searchableAttr.FieldType,
                Stored = searchableAttr.Stored,
                IsFacet = facetAttr is not null,
                IsArray = prop.PropertyType.IsArray
            });
        }

        DocumentFields<T>.SetFields(fields);
    }
}
