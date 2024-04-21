using Lucene.Net.Index;
using MusicLibrary.Common.Extensions;
using MusicLibrary.Indexer.Extensions;
using MusicLibrary.Indexer.Helpers;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Dto;
using MusicLibrary.Indexer.Models.Internal;
using MusicLibrary.Indexer.Models.Requests;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MusicLibrary.Indexer.Engine;

public class GenericSearchIndexEngine<T> : ISearchIndexEngine<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private readonly string _sharedIndexName;

    #region Constructors

    public GenericSearchIndexEngine()
    {
        _sharedIndexName = string.Empty;
        DocumentModelHelpers<T>.ReflectDocumentFields();
    }

    public GenericSearchIndexEngine(string indexName)
    {
        _sharedIndexName = indexName;
        DocumentModelHelpers<T>.ReflectDocumentFields();
    }

    #endregion

    #region Public methods

    public void AddOrUpdateDocuments(IEnumerable<T> contents, CancellationToken ct = default)
    {
        if (!contents.Any()) return;

        var docWriter = new DocumentWriter(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, this.GetFieldName(x => x.Id));
        var docReader = docWriter.GetDirectoryReader();

        Parallel.ForEach(contents, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = ct }, x =>
        {
            if (docReader.DocFreq(new Term(this.GetFieldName(x => x.Id), x.Id)) != 0)
                docWriter.Update(x.MapToLuceneDocument());
            else
                docWriter.Add(x.MapToLuceneDocument());
        });

        docWriter.Commit();
        docWriter.Dispose();
        docReader.Dispose();
    }

    public void DeleteAll()
    {
        using var docWriter = new DocumentWriter(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, this.GetFieldName(x => x.Id));
        docWriter.DeleteAll();
    }

    public void DeleteById(string[] ids)
    {
        using var docWriter = new DocumentWriter(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, this.GetFieldName(x => x.Id));
        docWriter.DeleteById(ids);
    }

    public IEnumerable<T> GetByIds(string[] ids)
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);
        return docReader.GetByIds(ids).Select(x => new T().MapFromLuceneDocument(x));
    }

    public bool IndexNotExistsOrEmpty()
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);
        return docReader.IndexNotExistsOrEmpty();
    }

    public bool DocumentExists(string id)
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);
        return docReader.DocumentExists(id);
    }

    public IEnumerable<string> FilterExistingDocuments(IEnumerable<string> ids)
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);

        foreach (var id in ids)
            if (!docReader.DocumentExists(id.RemoveDriveInfo()))
                yield return id;
    }

    public SearchResultDto<T> Search(SearchRequest request)
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);
        return docReader.Search(request).ToDto<T>();
    }

    public IEnumerable<string> GetAllIndexedIds()
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);

        var res = new Collection<string>();
        var fields = MultiFields.GetFields(docReader.Reader);
        var terms = fields.GetTerms(this.GetFieldName(x => x.Id));
        var termsEnum = terms.GetEnumerator(null);

        while (termsEnum.MoveNext())
            res.Add(termsEnum.Term.Utf8ToString());

        return res;
    }

    public IDictionary<string, int> CountDocuments(CounterRequest? request)
    {
        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);

        if (request is null && docReader.Reader is not null)
            return new Dictionary<string, int> { { "Total", docReader.Reader.NumDocs } };

        return docReader.TermsCounter(request.Value.Field, request.Value.IsNumeric);
    }

    public IDictionary<string, string> GetLatestAddedItems(CounterRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        using var docReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, _sharedIndexName);
        return docReader.LatestAdded(request.Field, request.AdditionalField, request.SortByField, ListSortDirection.Descending, request.Top.Value);
    }

    #endregion
}
