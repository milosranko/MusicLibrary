﻿using Lucene.Net.Index;
using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MusicLibrary.Indexer.Engine;

public class GenericSearchIndexEngine<T> : ISearchIndexEngine<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private readonly IDocumentReader<T> _documentReader;
    private readonly IDocumentWriter<T> _documentWriter;
    private IDictionary<string, FieldProperties> _fields;

    private struct FieldProperties
    {
        public required string FieldName { get; set; }
        public required FieldTypeEnum FieldType { get; set; }
        public required bool Stored { get; set; }
        public required bool IsFacet { get; set; }
        public required bool IsArray { get; set; }
    }

    public GenericSearchIndexEngine()
    {
        ReflectDocumentFields();

        _documentReader = new DocumentReader<T>();
        _documentWriter = new DocumentWriter<T>();
    }

    private void ReflectDocumentFields()
    {
        var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
        _fields = new Dictionary<string, FieldProperties>(props.Length);
        SearchableAttribute? searchableAttr;
        FacetPropertyAttribute? facetAttr;

        foreach (var prop in props)
        {
            searchableAttr = prop.GetCustomAttribute<SearchableAttribute>();
            facetAttr = prop.GetCustomAttribute<FacetPropertyAttribute>();

            if (searchableAttr is null) continue;

            _fields.Add(prop.Name, new FieldProperties
            {
                FieldName = string.IsNullOrEmpty(searchableAttr.FieldName) ? prop.Name : searchableAttr.FieldName,
                FieldType = searchableAttr.FieldType,
                Stored = searchableAttr.Stored,
                IsFacet = facetAttr is not null,
                IsArray = prop.PropertyType.IsArray
            });
        }
    }

    public void AddOrUpdateDocuments(ConcurrentBag<T> contents, CancellationToken ct = default)
    {
        if (contents.IsEmpty) return;

        _documentWriter.Init();
        _documentReader.Init(_documentWriter.GetDirectoryReader());

        var tasks = contents.Select(x => Task.Run(() =>
        {
            if (_documentReader.DocumentExists(x.Id))
                _documentWriter.Update(x);
            else
                _documentWriter.Add(x);
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
        {
            if (_documentReader.DocumentExists(id))
            {
                result.Add(id);
            }
        }

        return result;
    }

    public IEnumerable<T> GetByIds(string[] ids)
    {
        _documentReader.Init();
        return _documentReader.GetByIds(ids);
    }

    public bool IndexNotExistsOrEmpty()
    {
        _documentReader.Init();
        return _documentReader.IndexNotExistsOrEmpty();
    }

    public SearchResult<T> Search(SearchRequest request)
    {
        _documentReader.Init();
        return _documentReader.Search(request);
    }

    public IEnumerable<string> GetAllIndexedIds()
    {
        _documentReader.Init();

        var res = new Collection<string>();
        var fields = MultiFields.GetFields(_documentReader.Reader);
        var terms = fields.GetTerms(nameof(IDocument.Id).ToLower());
        var termsEnum = terms.GetEnumerator(null);

        while (termsEnum.MoveNext() == true)
        {
            res.Add(termsEnum.Term.Utf8ToString());
        }

        return res;
    }

    public IDictionary<string, int> CountDocuments(CounterRequest? request)
    {
        _documentReader.Init();

        if (request is null && _documentReader.Reader is not null)
            return new Dictionary<string, int> { { "Total", _documentReader.Reader.NumDocs } };

        //Most frequent terms
        return _documentReader.TermsCounter(request.Value.Field, request.Value.IsNumeric);
    }

    //private IDictionary<string, string> GetLatestAddedItems(IndexSearcher searcher, string field, int count)
    //{
    //    var res = new Dictionary<string, string>();
    //    var query = new MatchAllDocsQuery();
    //    var sort = new Sort(new SortField(field, SortFieldType.INT64, true));
    //    var topDocs = searcher.Search(query, count, sort);
    //    string artist, release, folder, prevFolder = null;

    //    for (int i = 0; i < topDocs.ScoreDocs.Length; i++)
    //    {
    //        folder = Path.GetDirectoryName(searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(IDocument.Id)));
    //        artist = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(Content.Artist));
    //        release = searcher.Doc(topDocs.ScoreDocs[i].Doc).Get(nameof(Content.Album));

    //        if (!res.Contains(new KeyValuePair<string, string>(artist, release)) && prevFolder != folder)
    //            res.Add(artist, release);

    //        if (res.Count == 50)
    //            break;

    //        if (prevFolder != folder)
    //            prevFolder = folder;
    //    }

    //    return res;
    //}

    public string GetFieldName(Expression<Func<T, string>> expr)
    {
        if (_fields is null || _fields.Count.Equals(0))
            ArgumentNullException.ThrowIfNull(_fields);

        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        if (!_fields.ContainsKey(memberExpression.Member.Name))
            throw new ArgumentException($"The provided property doesn't exists: {memberExpression.Member.Name}.");

        return _fields[memberExpression.Member.Name].FieldName;
    }

    public string GetFieldName(Expression<Func<T, int>> expr)
    {
        if (_fields is null || _fields.Count.Equals(0))
            ArgumentNullException.ThrowIfNull(_fields);

        if (expr.Body is not MemberExpression memberExpression)
            throw new ArgumentException($"The provided expression contains a {expr.GetType().Name} which is not supported. Only simple member accessors (fields, properties) of an object are supported.");

        if (!_fields.ContainsKey(memberExpression.Member.Name))
            throw new ArgumentException($"The provided property doesn't exists: {memberExpression.Member.Name}.");

        return _fields[memberExpression.Member.Name].FieldName;
    }
}
