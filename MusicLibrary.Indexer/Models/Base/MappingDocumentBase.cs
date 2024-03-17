using Lucene.Net.Documents;
using Lucene.Net.Facet;
using MusicLibrary.Indexer.Facets.Attributes;
using System.Linq;
using System.Reflection;

namespace MusicLibrary.Indexer.Models.Base;

public abstract class MappingDocumentBase<T> where T : IDocument, new()
{
    public virtual Document MapToLuceneDocument()
    {
        //TODO Discover model properties

        //var document = new Document
        //{
        //    new StringField(nameof(Id), Id, Field.Store.YES),
        //    new StringField(nameof(FileId), FileId, Field.Store.YES),
        //    new StringField(nameof(Drive), Drive, Field.Store.YES),
        //    new StringField(nameof(FileName), FileName, Field.Store.YES),
        //    new StringField(nameof(Extension), Extension, Field.Store.YES),
        //    new NumericDocValuesField(nameof(ModifiedDate), ModifiedDate.Ticks),
        //    new StringField(nameof(Artist), Artist, Field.Store.YES),
        //    new StringField(nameof(Album), Album, Field.Store.YES),
        //    new StringField(nameof(Genre), Genre, Field.Store.YES),
        //    new Int32Field(nameof(Year), Year != 0 ? Year : default, Field.Store.YES),
        //    new TextField(nameof(Text), Text ?? "", Field.Store.NO),
        //    //Facet Fields
        //    new FacetField(nameof(Artist), Artist),
        //    new FacetField(nameof(Album), Album),
        //    new FacetField(nameof(Genre), Genre),
        //    new FacetField(nameof(Year), Year.ToString()),
        //    new FacetField(nameof(Extension), Extension)
        //};

        //foreach (var tag in Tags)
        //    document.Add(new StringField(nameof(Tags), string.IsNullOrEmpty(tag) ? "" : tag, Field.Store.YES));

        //return document;
        return default;
    }

    public virtual T MapFromLuceneDocument(Document document)
    {
        //TODO Add mapping logic
        //_ = int.TryParse(document.Get(nameof(Year)), out var year);
        //FileId = document.Get(nameof(FileId));
        //Artist = document.Get(nameof(Artist));
        //Album = document.Get(nameof(Album));
        //Year = year;
        //Drive = document.Get(nameof(Drive));
        //Extension = document.Get(nameof(Extension));
        //FileName = document.Get(nameof(FileName));
        //Genre = document.Get(nameof(Genre));
        //Tags = document.GetValues(nameof(Tags));
        //Text = document.Get(nameof(Text));

        return default;
    }

    public virtual FacetsConfig GetFacetsConfig()
    {
        var facetsConfig = new FacetsConfig();
        var facetFields = typeof(T).GetProperties()
            .Where(p => p.GetCustomAttributes().OfType<MultiValueFacetPropertyAttribute>() != null)
            .Select(p => p.Name);

        foreach (var field in facetFields)
        {
            facetsConfig.SetMultiValued(field, true);
        }

        return facetsConfig;
    }
}
