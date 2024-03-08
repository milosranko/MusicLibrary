using System;

namespace MusicLibrary.Indexer.Models;

public struct Content
{
    public string FileId { get; set; } //Unique file location eg. root\sub\sub\sub\File.ext
    public string Drive { get; set; } //Drive name eg. d:\
    public string FileName { get; set; } //original file name without extension
    public string Extension { get; set; } //mp3/flac...
    public DateTime ModifiedDate { get; set; } //file modified date
    public string Artist { get; set; }
    public string Album { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Text { get; set; } //Combined file info and meta data + extension, space delimited, split path by segment, remove special characters from file name ?!_-.% and replace with space, artist, album, song, genre, year
    public string[] Tags { get; set; } //Meta tags: Artist/Album/Year/Genre/Title/TrackNo/IsHiRes
}
