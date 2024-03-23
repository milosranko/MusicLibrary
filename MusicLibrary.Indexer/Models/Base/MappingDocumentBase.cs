using Lucene.Net.Documents;
using Lucene.Net.Documents.Extensions;
using Lucene.Net.Facet;
using MusicLibrary.Indexer.Attributes;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace MusicLibrary.Indexer.Models.Base;

public abstract class MappingDocumentBase<T> : IEqualityComparer<IDocument> where T : IDocument, new()
{
    public virtual Document MapToLuceneDocument()
    {
        var document = new Document();
        var properties = typeof(T)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(x => x.GetCustomAttribute<SearchableAttribute>() is not null);

        foreach (var property in properties)
        {
            var searchableAttr = property.GetCustomAttribute<SearchableAttribute>();
            var facetAttr = property.GetCustomAttribute<FacetPropertyAttribute>();
            var propName = string.IsNullOrEmpty(searchableAttr?.FieldName) ? property.Name : searchableAttr.FieldName;
            var propValue = property.GetValue(this);

            if (facetAttr is not null && propValue is not null)
                document.AddFacetField(propName, propValue.ToString());

            if (property.PropertyType.IsArray)
            {
                var facetAttribute = property.GetCustomAttribute<FacetPropertyAttribute>();
                var array = (Array?)propValue;

                if (array is null) continue;

                foreach (var arrayItem in array)
                {
                    var arrValue = arrayItem?.ToString() ?? string.Empty;

                    document.Add(new StringField(propName, arrValue, searchableAttr.Stored ? Field.Store.YES : Field.Store.NO));

                    if (facetAttribute != null)
                        document.Add(new FacetField(propName, arrValue));
                }
            }
            else
                switch (searchableAttr.FieldType)
                {
                    case FieldTypeEnum.StringField:
                        document.AddStringField(
                            propName,
                            (string)propValue,
                            searchableAttr.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.TextField:
                        document.AddTextField(
                            propName,
                            (string)propValue,
                            searchableAttr.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.Int32Field:
                        document.AddInt32Field(
                            propName,
                            (int)propValue,
                            searchableAttr.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.NumericDocValuesField:
                        document.AddNumericDocValuesField(
                            propName,
                            ((DateTime)propValue).Ticks);

                        if (searchableAttr.Stored)
                            document.AddStoredField(propName, ((DateTime)propValue).Ticks);
                        break;
                }
        }

        return document;
    }

    public virtual T MapFromLuceneDocument(Document document)
    {
        var instance = new T();
        var properties = typeof(T)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(x => x.GetCustomAttribute<SearchableAttribute>() is not null);

        foreach (var property in properties)
        {
            var searchableAttr = property.GetCustomAttribute<SearchableAttribute>();
            var propName = string.IsNullOrEmpty(searchableAttr?.FieldName) ? property.Name : searchableAttr.FieldName;

            if (!searchableAttr.Stored) continue;

            if (property.PropertyType.IsArray)
                property.SetValue(instance, document.GetFields(propName).Select(x => x.GetStringValue()).ToArray());
            else if (property.PropertyType == typeof(DateTime) && searchableAttr.FieldType == FieldTypeEnum.NumericDocValuesField)
                property.SetValue(instance, new DateTime(document.GetField(propName).GetInt64Value().Value));
            else if (property.PropertyType == typeof(string))
                property.SetValue(instance, document.GetField(propName).GetStringValue());
            else if (property.PropertyType == typeof(int))
                property.SetValue(instance, document.GetField(propName).GetInt32Value());
        }

        return instance;
    }

    public bool Equals(IDocument? x, IDocument? y)
    {
        if (x is null || y is null) return false;

        return x.Id == y.Id;
    }

    public int GetHashCode([DisallowNull] IDocument obj)
    {
        return obj.Id.GetHashCode();
    }
}
