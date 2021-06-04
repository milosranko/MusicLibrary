using Lucene.Net.Documents;
using MusicLibrary.Indexer.Models;
using MusicLibrary.Indexer.Models.Constants;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Indexer.ModelBuilders
{
    internal class DocumentModelBuilders
    {
        public static Document BuildContentDocument(Content content)
        {
            var document = new Document
            {
                new StringField(FieldNames.Id, content.FileId, Field.Store.YES),
                new StringField(FieldNames.Name, content.FileName, Field.Store.YES),
                new StringField(FieldNames.Extension, content.Extension, Field.Store.YES),
                new NumericDocValuesField(FieldNames.ModifiedDate, content.ModifiedDate.Ticks),
                new StringField(FieldNames.Artist, content.Artist ?? "", Field.Store.YES),
                new StringField(FieldNames.Album, content.Album ?? "", Field.Store.YES),
                new StringField(FieldNames.Genre, content.Genre ?? "", Field.Store.YES),
                new Int32Field(FieldNames.Year, content.Year != 0 ? content.Year : default, Field.Store.YES),
                new TextField(FieldNames.Text, content.Text ?? "", Field.Store.NO)
            };

            foreach (var tag in content.Tags)
                document.Add(new StringField(FieldNames.Tags, string.IsNullOrEmpty(tag) ? "" : tag, Field.Store.YES));
            
            return document;
        }

        public static IEnumerable<Document> BuildContentDocuments(IEnumerable<Content> contents)
        {
            return contents.Select(BuildContentDocument);
        }
    }
}
