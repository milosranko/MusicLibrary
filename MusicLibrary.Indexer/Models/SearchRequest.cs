using MusicLibrary.Indexer.Models.Enums;

namespace MusicLibrary.Indexer.Models
{
    public struct SearchRequest
    {
        public string Text { get; set; }
        public string[] Terms { get; set; }
        public Pagination Pagination { get; set; }
        public QueryTypesEnum QueryType { get; set; }
        public string[] Fields { get; set; }
    }
}
