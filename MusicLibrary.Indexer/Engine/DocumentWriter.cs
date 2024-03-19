﻿using Lucene.Net.Analysis.Core;
using Lucene.Net.Facet;
using Lucene.Net.Facet.Taxonomy.Directory;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Util;
using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MusicLibrary.Indexer.Engine;

public class DocumentWriter<T> : IDisposable, IDocumentWriter<T> where T : MappingDocumentBase<T>, IDocument, new()
{
    private const LuceneVersion AppLuceneVersion = LuceneVersion.LUCENE_48;
    private readonly FacetsConfig _facetsConfig = new();
    private IndexWriter? _writer;
    private DirectoryTaxonomyWriter? _taxoWriter;
    private Directory? _indexDirectory;
    private Directory? _facetIndexDirectory;
    private readonly string _indexName;
    private bool _isInitialized = false;
    private bool _hasFacets = false;

    public DocumentWriter()
    {
        _indexName = typeof(T).GetCustomAttribute<IndexConfigAttribute>()?.IndexName ?? "index";
        _hasFacets = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.GetCustomAttribute<FacetPropertyAttribute>() != null || p.GetCustomAttribute<MultiValueFacetPropertyAttribute>() != null)
            .Any();
    }

    public void Init()
    {
        if (_isInitialized)
            return;

        var path = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData,
            Environment.SpecialFolderOption.Create) + $"\\MusicLibrary\\index\\{_indexName}";

        _indexDirectory = FSDirectory.Open(path);
        _writer = new IndexWriter(
            _indexDirectory,
            new IndexWriterConfig(AppLuceneVersion, new WhitespaceAnalyzer(AppLuceneVersion)) { OpenMode = OpenMode.CREATE_OR_APPEND });

        if (_hasFacets)
        {
            var pathTaxo = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData,
                Environment.SpecialFolderOption.Create) + $"\\MusicLibrary\\index\\{_indexName}-taxo";

            _facetIndexDirectory = FSDirectory.Open(pathTaxo);
            _taxoWriter = new DirectoryTaxonomyWriter(
                _facetIndexDirectory,
                OpenMode.CREATE_OR_APPEND);
        }

        _isInitialized = true;
    }

    public void Add(T document)
    {
        ArgumentNullException.ThrowIfNull(document);
        ArgumentNullException.ThrowIfNull(_writer);

        if (string.IsNullOrEmpty(document.Id))
            throw new ArgumentNullException(nameof(document.Id));

        if (_hasFacets)
        {
            _writer?.AddDocument(_facetsConfig.Build(
                _taxoWriter,
                document.MapToLuceneDocument()));
        }
        else
        {
            _writer?.AddDocument(document.MapToLuceneDocument());
        }
    }

    public void AddRange(IEnumerable<T> documents)
    {
        ArgumentNullException.ThrowIfNull(documents);
        ArgumentNullException.ThrowIfNull(_writer);

        if (_hasFacets)
        {
            _writer.AddDocuments(documents.Select(x => _facetsConfig.Build(
                _taxoWriter, x.MapToLuceneDocument())));
        }
        else
        {
            _writer.AddDocuments(documents.Select(x => x.MapToLuceneDocument()));
        }
    }

    public void Commit()
    {
        _writer?.Commit();

        if (_hasFacets)
            _taxoWriter?.Commit();
    }

    public void Delete(T document)
    {
        _writer?.DeleteDocuments(new Term(nameof(IDocument.Id).ToLower(), document.Id));
    }

    public void DeleteAll()
    {
        _writer?.DeleteAll();
        _writer?.Commit();

        //if (!_hasFacets || _taxoWriter is null)
        //    return;

        //foreach (var item in _taxoWriter.Directory.ListAll().Where(x => !x.Equals("write.lock") && !x.StartsWith("segments")))
        //    _taxoWriter.Directory.DeleteFile(item);
    }

    public void DeleteById(string[] ids)
    {
        if (ids == null || ids.Length == 0) return;

        _writer?.DeleteDocuments(ids.Select(x => new Term(nameof(IDocument.Id).ToLower(), x)).ToArray());
        _writer?.Commit();
    }

    public void Update(T document)
    {
        var indexTerm = new Term(nameof(IDocument.Id).ToLower(), document.Id);

        if (_hasFacets)
        {
            _writer?.UpdateDocument(indexTerm, _facetsConfig.Build(
                _taxoWriter,
                document.MapToLuceneDocument()));
        }
        else
        {
            _writer?.UpdateDocument(indexTerm, document.MapToLuceneDocument());
        }
    }

    public void Dispose()
    {
        //_indexDirectory?.Dispose();
        _writer?.Dispose();

        if (_hasFacets)
        {
            _facetIndexDirectory?.Dispose();
            _taxoWriter?.Dispose();
        }
    }

    public DirectoryReader GetDirectoryReader()
    {
        if (_writer is null)
            throw new InvalidOperationException();

        return _writer.GetReader(false);
    }
}