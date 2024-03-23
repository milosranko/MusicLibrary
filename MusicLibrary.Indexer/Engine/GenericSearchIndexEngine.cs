using Lucene.Net.Index;
using MusicLibrary.Indexer.Extensions;
using MusicLibrary.Indexer.Helpers;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Dto;
using MusicLibrary.Indexer.Models.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Indexer.Engine;

public class GenericSearchIndexEngine<T> : ISearchIndexEngine<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private readonly IDocumentReader _documentReader;
    private readonly IDocumentWriter _documentWriter;

    #region Constructors

    public GenericSearchIndexEngine()
    {
        DocumentModelHelpers<T>.ReflectDocumentFields();

        _documentReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets);
        _documentWriter = new DocumentWriter(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, this.GetFieldName(x => x.Id));
    }

    public GenericSearchIndexEngine(string indexName)
    {
        DocumentModelHelpers<T>.ReflectDocumentFields();

        _documentReader = new DocumentReader(DocumentFields<T>.IndexName, DocumentFields<T>.FacetsConfig, DocumentFields<T>.HasFacets, sharedIndexName: indexName);
    }

    #endregion

    #region Public methods

    public void AddOrUpdateDocuments(IEnumerable<T> contents, CancellationToken ct = default)
    {
        if (!contents.Any()) return;

        _documentWriter.Init();
        _documentReader.Init(_documentWriter.GetDirectoryReader());

        Parallel.ForEach(contents, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = ct }, x =>
        {
            if (_documentReader.DocumentExists(x.Id))
                _documentWriter.Update(x.MapToLuceneDocument());
            else
                _documentWriter.Add(x.MapToLuceneDocument());
        });

        _documentWriter.Commit();
        _documentWriter.Dispose();
        _documentReader.Dispose();
    }

    public void DeleteAll()
    {
        _documentWriter.Init();
        _documentWriter.DeleteAll();
        _documentWriter.Dispose();
    }

    public void DeleteById(string[] ids)
    {
        _documentWriter.Init();
        _documentWriter.DeleteById(ids);
        _documentWriter.Dispose();
    }

    public IEnumerable<string> SkipExistingDocuments(string[] ids)
    {
        if (ids.Length == 0)
            return [];

        var result = new Collection<string>();

        foreach (var id in ids)
            if (_documentReader.DocumentExists(id))
                result.Add(id);

        return result;
    }

    public IEnumerable<T> GetByIds(string[] ids)
    {
        _documentReader.Init();
        return _documentReader.GetByIds(ids).Select(x => new T().MapFromLuceneDocument(x));
    }

    public bool IndexNotExistsOrEmpty()
    {
        _documentReader.Init();
        return _documentReader.IndexNotExistsOrEmpty();
    }

    public SearchResultDto<T> Search(SearchRequest request)
    {
        _documentReader.Init();
        return _documentReader.Search(request).ToDto<T>();
    }

    public IEnumerable<string> GetAllIndexedIds()
    {
        _documentReader.Init();

        var res = new Collection<string>();
        var fields = MultiFields.GetFields(_documentReader.Reader);
        var terms = fields.GetTerms(this.GetFieldName(x => x.Id));
        var termsEnum = terms.GetEnumerator(null);

        while (termsEnum.MoveNext() == true)
            res.Add(termsEnum.Term.Utf8ToString());

        return res;
    }

    public IDictionary<string, int> CountDocuments(CounterRequest? request)
    {
        _documentReader.Init();

        if (request is null && _documentReader.Reader is not null)
            return new Dictionary<string, int> { { "Total", _documentReader.Reader.NumDocs } };

        return _documentReader.TermsCounter(request.Value.Field, request.Value.IsNumeric);
    }

    public IDictionary<string, string> GetLatestAddedItems(CounterRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        _documentReader.Init();

        return _documentReader.LatestAdded(request.Field, request.AdditionalField, request.SortByField, ListSortDirection.Descending, request.Top.Value);
    }

    #endregion
}
