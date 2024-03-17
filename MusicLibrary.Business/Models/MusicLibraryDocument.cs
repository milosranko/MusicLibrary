using MusicLibrary.Indexer.Facets.Attributes;
using MusicLibrary.Indexer.Models.Base;
using System;

namespace MusicLibrary.Business.Models;

[IndexConfig(IndexName = "music-library")]
public class MusicLibraryDocument : MappingDocumentBase<MusicLibraryDocument>, IDocument
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
}
