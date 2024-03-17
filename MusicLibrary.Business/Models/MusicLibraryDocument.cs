using MusicLibrary.Indexer.Attributes;
using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models.Base;
using System;

namespace MusicLibrary.Business.Models;

[IndexConfig(IndexName = "music-library")]
public class MusicLibraryDocument : MappingDocumentBase<MusicLibraryDocument>, IDocument
{
    [Searchable(FieldName = "id", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Id => FileId;

    [Searchable(FieldName = "fid", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string FileId { get; set; } //Unique file location eg. root\sub\sub\sub\File.ext

    [Searchable(FieldName = "drv", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Drive { get; set; } //Drive name eg. d:\

    [Searchable(FieldName = "fnm", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string FileName { get; set; } //original file name without extension

    [Searchable(FieldName = "ext", FieldType = FieldTypeEnum.StringField, Stored = true)]
    [FacetProperty]
    public string Extension { get; set; } //mp3/flac...

    [Searchable(FieldName = "mdt", FieldType = FieldTypeEnum.NumericDocValuesField)]
    public DateTime ModifiedDate { get; set; } //file modified dates

    [Searchable(FieldName = "art", FieldType = FieldTypeEnum.StringField, Stored = true)]
    [FacetProperty]
    public string Artist { get; set; }

    [Searchable(FieldName = "rel", FieldType = FieldTypeEnum.StringField, Stored = true)]
    [FacetProperty]
    public string Release { get; set; }

    [Searchable(FieldName = "yer", FieldType = FieldTypeEnum.Int32Field, Stored = true)]
    [FacetProperty]
    public int Year { get; set; }

    [FacetProperty]
    [Searchable(FieldName = "gnr", FieldType = FieldTypeEnum.StringField, Stored = true)]
    public string Genre { get; set; }

    [Searchable(FieldName = "txt", FieldType = FieldTypeEnum.TextField, Stored = false)]
    public string Text { get; set; } //Combined file info and meta data + extension, space delimited, split path by segment, remove special characters from file name ?!_-.% and replace with space, artist, album, song, genre, year

    [Searchable(FieldName = "tag", FieldType = FieldTypeEnum.StringField, Stored = true)]
    [MultiValueFacetProperty]
    public string[] Tags { get; set; } //Meta tags: Artist/Album/Year/Genre/Title/TrackNo/IsHiRes
}
