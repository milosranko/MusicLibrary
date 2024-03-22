﻿using Lucene.Net.Index;
using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Extensions;
using MusicLibrary.Indexer.Helpers;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Dto;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Indexer.Engine;

public class GenericSearchIndexEngine<T> : ISearchIndexEngine<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private readonly IDocumentReader _documentReader;
    private readonly IDocumentWriter _documentWriter;
    private readonly string _indexName;
    private readonly bool _hasFacets;

    #region Constructors

    public GenericSearchIndexEngine()
    {
        _indexName = typeof(T).GetCustomAttribute<IndexConfigAttribute>()?.IndexName ?? "index";
        _hasFacets = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.GetCustomAttribute<FacetPropertyAttribute>() != null || p.GetCustomAttribute<MultiValueFacetPropertyAttribute>() != null)
            .Any();

        DocumentModelHelpers<T>.ReflectDocumentFields();

        _documentReader = new DocumentReader(_indexName, DocumentModelHelpers<T>.GetFacetsConfig(), _hasFacets);
        _documentWriter = new DocumentWriter(_indexName, _hasFacets, this.GetFieldName(x => x.Id));
    }

    #endregion

    #region Public methods

    public void AddOrUpdateDocuments(ConcurrentBag<T> contents, CancellationToken ct = default)
    {
        if (contents.IsEmpty) return;

        _documentWriter.Init();
        _documentReader.Init(_documentWriter.GetDirectoryReader());

        var tasks = contents.Select(x => Task.Run(() =>
        {
            if (_documentReader.DocumentExists(x.Id))
                _documentWriter.Update(x.MapToLuceneDocument());
            else
                _documentWriter.Add(x.MapToLuceneDocument());
        }));

        Task.WhenAll(tasks).Wait(ct);

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
