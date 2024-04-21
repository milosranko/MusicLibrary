using Lucene.Net.Documents;
using Lucene.Net.Documents.Extensions;
using Lucene.Net.Facet;
using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Models.Internal;
using System.Diagnostics.CodeAnalysis;

namespace MusicLibrary.Indexer.Models.Base;

public abstract class MappingDocumentBase<T> : IEqualityComparer<IDocument> where T : IDocument, new()
{
    public virtual Document MapToLuceneDocument()
    {
        var document = new Document();

        foreach (var field in DocumentFields<T>.Fields)
        {
            var propValue = field.Value.PropertyInfo.GetValue(this);

            if (field.Value.IsFacet && propValue is not null)
                document.AddFacetField(field.Value.FieldName, propValue.ToString());

            if (field.Value.IsArray)
            {
                var array = (Array?)propValue;

                if (array is null) continue;

                foreach (var arrayItem in array)
                {
                    var arrValue = arrayItem?.ToString() ?? string.Empty;

                    document.Add(new StringField(field.Value.FieldName, arrValue, field.Value.Stored ? Field.Store.YES : Field.Store.NO));

                    if (field.Value.IsFacet)
                        document.Add(new FacetField(field.Value.FieldName, arrValue));
                }
            }
            else
                switch (field.Value.FieldType)
                {
                    case FieldTypeEnum.StringField:
                        document.AddStringField(
                            field.Value.FieldName,
                            (string)propValue,
                            field.Value.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.TextField:
                        document.AddTextField(
                            field.Value.FieldName,
                            (string)propValue,
                            field.Value.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.Int32Field:
                        document.AddInt32Field(
                            field.Value.FieldName,
                            (int)propValue,
                            field.Value.Stored ? Field.Store.YES : Field.Store.NO);
                        break;
                    case FieldTypeEnum.NumericDocValuesField:
                        document.AddNumericDocValuesField(
                            field.Value.FieldName,
                            ((DateTime)propValue).Ticks);

                        if (field.Value.Stored)
                            document.AddStoredField(field.Value.FieldName, ((DateTime)propValue).Ticks);
                        break;
                }
        }

        return document;
    }

    public virtual T MapFromLuceneDocument(Document document)
    {
        var instance = new T();

        foreach (var field in DocumentFields<T>.Fields)
        {
            if (!field.Value.Stored) continue;

            if (field.Value.IsArray)
                field.Value.PropertyInfo.SetValue(instance, document.GetFields(field.Value.FieldName).Select(x => x.GetStringValue()).ToArray());
            else if (field.Value.PropertyInfo.PropertyType == typeof(DateTime) && field.Value.FieldType == FieldTypeEnum.NumericDocValuesField)
                field.Value.PropertyInfo.SetValue(instance, new DateTime(document.GetField(field.Value.FieldName).GetInt64Value().Value));
            else if (field.Value.FieldType == FieldTypeEnum.StringField)
                field.Value.PropertyInfo.SetValue(instance, document.GetField(field.Value.FieldName).GetStringValue());
            else if (field.Value.FieldType == FieldTypeEnum.Int32Field)
                field.Value.PropertyInfo.SetValue(instance, document.GetField(field.Value.FieldName).GetInt32Value());
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
