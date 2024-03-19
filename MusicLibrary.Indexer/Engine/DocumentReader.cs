﻿using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Core;
using Lucene.Net.Facet;
using Lucene.Net.Facet.Taxonomy;
using Lucene.Net.Facet.Taxonomy.Directory;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Search.Grouping;
using Lucene.Net.Store;
using Lucene.Net.Util;
using MusicLibrary.Indexer.Facets;
using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Base;
using MusicLibrary.Indexer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace MusicLibrary.Indexer.Engine;

public class DocumentReader<T> : IDisposable, IDocumentReader<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    public DirectoryReader? Reader => _reader;
    private const LuceneVersion AppLuceneVersion = LuceneVersion.LUCENE_48;
    private DirectoryReader? _reader;
    private DirectoryTaxonomyReader? _taxoReader;
    private Analyzer? _analyzer;
    private readonly string _indexName;
    private bool _isInitialized = false;
    private bool _hasFacets = false;

    public DocumentReader()
    {
        _indexName = typeof(T).GetCustomAttribute<IndexConfigAttribute>()?.IndexName ?? "index";
        _hasFacets = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.GetCustomAttribute<FacetPropertyAttribute>() != null || p.GetCustomAttribute<MultiValueFacetPropertyAttribute>() != null)
            .Any();
    }

    public bool DocumentExists(string id)
    {
        return _reader is null ? false : _reader.DocFreq(new Term(nameof(IDocument.Id).ToLower(), id)) != 0;
    }

    public IDictionary<string, int> TermsCounter(string field, bool isNumeric = false)
    {
        var res = new Dictionary<string, int>();
        var searcher = new IndexSearcher(_reader);
        var fields = MultiFields.GetFields(searcher.IndexReader);
        var terms = fields.GetTerms(field);
        var termsEnum = terms.GetEnumerator();

        while (termsEnum.MoveNext() == true)
        {
            var collector = new TotalHitCountCollector();
            searcher.CollectionStatistics(field);
            searcher.Search(new TermQuery(new Term(field, termsEnum.Term)), collector);

            if (collector.TotalHits > 0)
            {
                if (isNumeric)
                {
                    if (!res.ContainsKey(NumericUtils.PrefixCodedToInt32(termsEnum.Term).ToString()) && NumericUtils.PrefixCodedToInt32(termsEnum.Term) > 1920)
                        res.Add(NumericUtils.PrefixCodedToInt32(termsEnum.Term).ToString(), collector.TotalHits);
                }
                else if (!res.ContainsKey(termsEnum.Term.Utf8ToString()))
                    res.Add(termsEnum.Term.Utf8ToString(), collector.TotalHits);
            }
        }

        return res;
    }

    public IDictionary<string, string> LatestAdded(string field, string additionalField, string sortBy, ListSortDirection sortDirection, int top)
    {
        var sort = new Sort(new SortField(sortBy, SortFieldType.INT64, sortDirection.Equals(ListSortDirection.Descending)));
        var res = new Dictionary<string, string>();
        var searcher = new IndexSearcher(_reader);
        var query = new MatchAllDocsQuery();
        var groupingSearch = new GroupingSearch(field);
        groupingSearch.SetGroupSort(sort);
        //groupingSearch.SetFillSortFields(true);
        groupingSearch.SetGroupDocsLimit(1);
        var groupingDocs = groupingSearch.SearchByField(searcher, query, 0, 50);

        foreach (var item in groupingDocs.Groups)
            res.Add(item.GroupValue.Utf8ToString(), searcher.Doc(item.ScoreDocs[0].Doc).Get(additionalField));

        return res;
    }

    public IEnumerable<T> GetByIds(string[] ids)
    {
        if (ids == null || ids.Length == 0)
            return [];

        var hits = new Collection<T>();
        var searcher = new IndexSearcher(_reader);

        TermQuery q;
        var model = Activator.CreateInstance<T>();

        foreach (var id in ids)
        {
            q = new TermQuery(new Term(nameof(IDocument.Id).ToLower(), id));

            var res = searcher.Search(q, 1);
            if (res.TotalHits == 0) continue;

            hits.Add(model.MapFromLuceneDocument(searcher.Doc(res.ScoreDocs[0].Doc)));
        }

        return hits;
    }

    public bool IndexNotExistsOrEmpty()
    {
        return _reader is null ? true : _reader.NumDocs == 0;
    }

    public SearchResult<T> Search(SearchRequest request)
    {
        var searcher = new IndexSearcher(_reader);
        var searchResult = new SearchResult<T>
        {
            SearchText = request.Text,
            Hits = []
        };
        Query? q = null;

        switch (request.QueryType)
        {
            case QueryTypesEnum.Term:
                if (request.SearchFields is null || request.SearchFields.Count == 0)
                    break;

                q = new TermQuery(new Term(request.SearchFields.First().Key, request.SearchFields.First().Value));
                break;
            case QueryTypesEnum.MultiTerm:
                q = new BooleanQuery();

                if (request.SearchFields is null) break;

                foreach (var (fieldName, value) in request.SearchFields)
                {
                    Query searchQuery = request.SearchType switch
                    {
                        SearchType.ExactMatch => new TermQuery(new Term(fieldName, value)),
                        SearchType.PrefixMatch => new PrefixQuery(new Term(fieldName, value)),
                        SearchType.FuzzyMatch => new FuzzyQuery(new Term(fieldName, value)),
                        _ => new TermQuery(new Term(fieldName, value))
                    };

                    ((BooleanQuery)q).Add(searchQuery, Occur.MUST);
                }
                break;
            case QueryTypesEnum.Numeric:
                if (request.SearchFields is null || request.SearchFields.Count == 0)
                    break;

                q = NumericRangeQuery.NewInt32Range(request.SearchFields.First().Key, int.Parse(request.SearchFields.First().Value), int.Parse(request.SearchFields.First().Value), true, true);
                break;
            case QueryTypesEnum.Text:
                var parser = new QueryParser(AppLuceneVersion, request.SearchFields.First().Key, _analyzer)
                {
                    AllowLeadingWildcard = true,
                    DefaultOperator = Operator.AND
                };
                q = parser.Parse(request.Text);
                break;
        }

        var model = new T();

        if (request.Facets != null && request.Facets.Any())
            GetFacets(model, searcher, q, searchResult);

        var startIndex = request.Pagination.PageIndex * request.Pagination.PageSize;
        var topDocs = searcher.Search(q, startIndex + request.Pagination.PageSize);

        if (topDocs.TotalHits == 0) return searchResult;

        var hits = new List<T>(topDocs.ScoreDocs.Skip(startIndex).Count());

        foreach (var hit in topDocs.ScoreDocs.Skip(startIndex))
            hits.Add(new T().MapFromLuceneDocument(searcher.Doc(hit.Doc)));

        searchResult.TotalHits = topDocs.TotalHits;
        searchResult.Hits = hits;
        searchResult.Pagination = new Pagination(request.Pagination.PageSize, request.Pagination.PageIndex)
        {
            TotalPages = (int)Math.Ceiling(decimal.Divide(searchResult.TotalHits, request.Pagination.PageSize))
        };

        return searchResult;
    }

    public void Init()
    {
        if (_isInitialized)
            return;

        var path = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData,
            Environment.SpecialFolderOption.Create) + $"\\MusicLibrary\\index\\{_indexName}";

        if (!System.IO.Directory.Exists(path))
            return;

        _analyzer = new WhitespaceAnalyzer(AppLuceneVersion);
        _reader = DirectoryReader.Open(FSDirectory.Open(path));

        var pathTaxo = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData,
            Environment.SpecialFolderOption.Create) + $"\\MusicLibrary\\index\\{_indexName}-taxo";

        if (_hasFacets && System.IO.Directory.Exists(pathTaxo) && System.IO.Directory.GetFiles(pathTaxo).Length > 0)
            _taxoReader = new DirectoryTaxonomyReader(FSDirectory.Open(pathTaxo));

        _isInitialized = true;
    }

    public void Init(DirectoryReader reader)
    {
        _reader = reader;
    }

    private void GetFacets(T model, IndexSearcher searcher, Query q, SearchResult<T> searchResult)
    {
        var facetsConfig = model.GetFacetsConfig();

        if (facetsConfig == null)
            return;

        var fc = new FacetsCollector();
        FacetsCollector.Search(searcher, q, 100, fc);
        var facets = new FastTaxonomyFacetCounts(_taxoReader, facetsConfig, fc);
        var facetResults = facets.GetAllDims(100).Select(facet => new FacetFilter
        {
            Name = facet.Dim,
            Values = facet.LabelValues.Select(p => new FacetValue { Value = p.Label, Count = (int)p.Value, })
        });

        searchResult.Facets = facetResults;
    }

    public void Dispose()
    {
        _reader?.Dispose();
        _taxoReader?.Dispose();
        _analyzer?.Dispose();
    }
}