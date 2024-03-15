using Lucene.Net.Documents;
using Lucene.Net.Facet;
using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models.Attributes;
using MusicLibrary.Indexer.Models.Base;
using System;

namespace MusicLibrary.Indexer.Models;

[IndexConfig(IndexName = "music-library")]
public class Content : MappingDocumentBase<Content>, IDocument
{
    public string Id => FileId;
    public string FileId { get; set; } //Unique file location eg. root\sub\sub\sub\File.ext
    public string Drive { get; set; } //Drive name eg. d:\
    public string FileName { get; set; } //original file name without extension
    [FacetProperty]
    public string Extension { get; set; } //mp3/flac...
    public DateTime ModifiedDate { get; set; } //file modified dates
    [FacetProperty]
    public string Artist { get; set; }
    [FacetProperty]
    public string Album { get; set; }
    [FacetProperty]
    public int Year { get; set; }
    [FacetProperty]
    public string Genre { get; set; }
    public string Text { get; set; } //Combined file info and meta data + extension, space delimited, split path by segment, remove special characters from file name ?!_-.% and replace with space, artist, album, song, genre, year
    [MultiValueFacetProperty]
    public string[] Tags { get; set; } //Meta tags: Artist/Album/Year/Genre/Title/TrackNo/IsHiRes

    public override Document MapToLuceneDocument()
    {
        var document = new Document
        {
            new StringField(nameof(Id), Id, Field.Store.YES),
            new StringField(nameof(FileId), FileId, Field.Store.YES),
            new StringField(nameof(Drive), Drive, Field.Store.YES),
            new StringField(nameof(FileName), FileName, Field.Store.YES),
            new StringField(nameof(Extension), Extension, Field.Store.YES),
            new NumericDocValuesField(nameof(ModifiedDate), ModifiedDate.Ticks),
            new StringField(nameof(Artist), Artist, Field.Store.YES),
            new StringField(nameof(Album), Album, Field.Store.YES),
            new StringField(nameof(Genre), Genre, Field.Store.YES),
            new Int32Field(nameof(Year), Year != 0 ? Year : default, Field.Store.YES),
            new TextField(nameof(Text), Text ?? "", Field.Store.NO),
            //Facet Fields
            new FacetField(nameof(Artist), Artist),
            new FacetField(nameof(Album), Album),
            new FacetField(nameof(Genre), Genre),
            new FacetField(nameof(Year), Year.ToString()),
            new FacetField(nameof(Extension), Extension)
        };

        foreach (var tag in Tags)
            document.Add(new StringField(nameof(Tags), string.IsNullOrEmpty(tag) ? "" : tag, Field.Store.YES));

        return document;
    }

    public override Content MapFromLuceneDocument(Document document)
    {
        _ = int.TryParse(document.Get(nameof(Year)), out var year);
        FileId = document.Get(nameof(FileId));
        Artist = document.Get(nameof(Artist));
        Album = document.Get(nameof(Album));
        Year = year;
        Drive = document.Get(nameof(Drive));
        Extension = document.Get(nameof(Extension));
        FileName = document.Get(nameof(FileName));
        Genre = document.Get(nameof(Genre));
        Tags = document.GetValues(nameof(Tags));
        //Text = document.Get(nameof(Text));

        return this;
    }
}
