using MusicLibrary.Business.Enums;
using MusicLibrary.Business.Helpers;
using MusicLibrary.Indexer.Engine;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Constants;
using MusicLibrary.Indexer.Models.Enums;
using System.Threading.Tasks;

namespace MusicLibrary.Business
{
    public class IndexSearcher
    {
        private readonly SearchIndexEngine _engine;

        public IndexSearcher()
        {
            _engine = new SearchIndexEngine();
        }

        public bool IndexExists => !_engine.IndexNotExistsOrEmpty();

        public Task<SearchResult> Search(string query, string[] terms, SearchFieldsEnum searchField)
        {
            return searchField switch
            {
                SearchFieldsEnum.Text => Search(query.RemoveSpecialCharacters().ToLower(), terms, new string[1] { FieldNames.Text }, QueryTypesEnum.Text),
                SearchFieldsEnum.Genre => Search(query, terms, new string[1] { FieldNames.Genre }, QueryTypesEnum.Term),
                SearchFieldsEnum.Year => Search(query, terms, new string[1] { FieldNames.Year }, QueryTypesEnum.Numeric),
                SearchFieldsEnum.Extension => Search(query, terms, new string[1] { FieldNames.Extension }, QueryTypesEnum.Term),
                SearchFieldsEnum.Release => Search(query, terms, new string[2] { FieldNames.Artist, FieldNames.Album }, QueryTypesEnum.MultiTerm),
                _ => Search(query.RemoveSpecialCharacters().ToLower(), terms, new string[1] { FieldNames.Text }, QueryTypesEnum.Text),
            };
        }

        public Task<IndexCounts> GetIndexCounts()
        {
            if (!_engine.IndexNotExistsOrEmpty()) Task.FromResult(IndexCounts.Empty);

            return Task.FromResult(_engine.GetIndexStatistics());
        }

        public void CommitPendingChanges()
        {
            _engine.Commit();
        }

        private Task<SearchResult> Search(string query, string[] terms, string[] fields, QueryTypesEnum queryType)
        {
            if (string.IsNullOrEmpty(query) && (terms == null || terms.Length == 0)) return Task.FromResult(SearchResult.Empty());
            if (fields == null || fields.Length == 0) return Task.FromResult(SearchResult.Empty());

            var searchRequest = new SearchRequest
            {
                Text = query,
                Terms = terms,
                Fields = fields,
                QueryType = queryType,
                Pagination = new Pagination(50000, 0)
            };

            return Task.FromResult(_engine.Search(searchRequest));
        }
    }
}
