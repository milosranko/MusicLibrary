using Lucene.Net.Documents;
using Lucene.Net.Facet;
using MusicLibrary.Indexer.Facets.Attributes;
using System.Linq;
using System.Reflection;

namespace MusicLibrary.Indexer.Models.Base;

public abstract class MappingDocumentBase<TModel> where TModel : IDocument
{
    //public abstract string Id { get; }
    public abstract Document MapToLuceneDocument();
    public abstract TModel MapFromLuceneDocument(Document document);
    public virtual FacetsConfig GetFacetsConfig()
    {
        var facetsConfig = new FacetsConfig();
        var facetFields = typeof(TModel).GetProperties()
            .Where(p => p.GetCustomAttributes().OfType<MultiValueFacetPropertyAttribute>() != null)
            .Select(p => p.Name);

        foreach (var field in facetFields)
        {
            facetsConfig.SetMultiValued(field, true);
        }

        return facetsConfig;
    }
}
