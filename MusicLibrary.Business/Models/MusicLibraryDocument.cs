using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Models.Base;

namespace MusicLibrary.Business.Models;

[IndexConfig(IndexName = "music-library")]
public class MusicLibraryDocument : MappingDocumentBase<MusicLibraryDocument>, IDocument
{
    [Searchable(FieldName = "id", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Id { get; set; } //Unique file location eg. root\sub\sub\sub\File.ext

    [Searchable(FieldName = "drv", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Drive { get; set; } //Drive name eg. d:\

    [Searchable(FieldName = "fnm", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string FileName { get; set; } //original file name without extension

    [FacetProperty]
    [Searchable(FieldName = "ext", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Extension { get; set; } //mp3/flac...

    [Searchable(FieldName = "mdt", FieldType = FieldTypeEnum.NumericDocValuesField)]
    public DateTime ModifiedDate { get; set; } //file modified dates

    [FacetProperty]
    [Searchable(FieldName = "art", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Artist { get; set; }

    [FacetProperty]
    [Searchable(FieldName = "rel", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Release { get; set; }

    [FacetProperty]
    [Searchable(FieldName = "yer", FieldType = FieldTypeEnum.Int32Field, Stored = true)]
    public int Year { get; set; }

    [FacetProperty]
    [Searchable(FieldName = "gnr", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Genre { get; set; }

    [Searchable(FieldName = "txt", FieldType = FieldTypeEnum.TextField, Stored = false)]
    public string Text { get; set; } //Combined file info and meta data + extension, space delimited, split path by segment, remove special characters from file name ?!_-.% and replace with space, artist, album, song, genre, year

    [MultiValueFacetProperty]
    [Searchable(FieldName = "tag", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string[] Tags { get; set; } //Meta tags: Artist/Album/Year/Genre/Title/TrackNo/IsHiRes
}
