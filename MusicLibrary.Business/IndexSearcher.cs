using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Common;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Constants;
using MusicLibrary.Indexer.Models.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Business;

public class IndexSearcher
{
	//private readonly SearchIndexEngine _engine;
	private readonly string _indexName = string.Empty;
	public IEnumerable<string> SharedIndexes;

	public IndexSearcher()
	{
		//_engine = new SearchIndexEngine();
		SharedIndexes = GetSharedIndexes();
	}

	public IndexSearcher(string indexName)
	{
		_indexName = indexName;
		//_engine = new SearchIndexEngine(indexName);
	}

	public bool IndexExists()
	{
		using var engine = new SearchIndexEngine(_indexName);
		return !engine.IndexNotExistsOrEmpty();
	}

	private IEnumerable<string> GetSharedIndexes()
	{
		if (!Directory.Exists(Constants.LocalAppDataShares))
			return Enumerable.Empty<string>();

		return Directory.EnumerateDirectories(Constants.LocalAppDataShares)
			.Select(x => x.Split(Path.DirectorySeparatorChar).Last());
	}

	public Task<SearchResult> Search(string query, string[] terms, SearchFieldsEnum searchField)
	{
		return searchField switch
		{
			SearchFieldsEnum.Text => Search(query.RemoveSpecialCharacters().ToLower(), terms, [FieldNames.Text], QueryTypesEnum.Text),
			SearchFieldsEnum.Genre => Search(query, terms, [FieldNames.Genre], QueryTypesEnum.Term),
			SearchFieldsEnum.Year => Search(query, terms, [FieldNames.Year], QueryTypesEnum.Numeric),
			SearchFieldsEnum.Extension => Search(query, terms, [FieldNames.Extension], QueryTypesEnum.Term),
			SearchFieldsEnum.Release => Search(query, terms, [FieldNames.Artist, FieldNames.Album], QueryTypesEnum.MultiTerm),
			SearchFieldsEnum.Artist => Search(query, terms, [FieldNames.Artist], QueryTypesEnum.Term),
			_ => Search(query.RemoveSpecialCharacters().ToLower(), terms, [FieldNames.Text], QueryTypesEnum.Text),
		};
	}

	public IEnumerable<SearchHit> GetSearchResultByIds(string[] ids)
	{
		using var engine = new SearchIndexEngine(_indexName);

		if (engine.IndexNotExistsOrEmpty())
			return Enumerable.Empty<SearchHit>();

		return engine.GetById(ids);
	}

	public Task<IndexCounts> GetIndexCounts()
	{
		using var engine = new SearchIndexEngine(_indexName);

		if (engine.IndexNotExistsOrEmpty())
			return Task.FromResult(IndexCounts.Empty);

		return Task.FromResult(engine.GetIndexStatistics());
	}

	public void CommitPendingChanges()
	{
		using var engine = new SearchIndexEngine(_indexName);
		engine.Commit();
	}

	private Task<SearchResult> Search(string query, string[] terms, string[] fields, QueryTypesEnum queryType)
	{
		if (string.IsNullOrEmpty(query) && (terms == null || terms.Length == 0))
			return Task.FromResult(SearchResult.Empty());

		if (fields == null || fields.Length == 0)
			return Task.FromResult(SearchResult.Empty());

		var searchRequest = new SearchRequest
		{
			Text = query,
			Terms = terms,
			Fields = fields,
			QueryType = queryType,
			Pagination = new Pagination(50000, 0)
		};

		using var engine = new SearchIndexEngine(_indexName);
		return Task.FromResult(engine.Search(searchRequest));
	}
}
