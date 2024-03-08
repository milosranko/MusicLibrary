namespace MusicLibrary.Business.Models;

public class SearchResultModel
{
    public string Id { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int? Year { get; set; }
    public string TrackName { get; set; }
    public int? TrackNumber { get; set; }
    public string Tags { get; set; }
    public string Path { get; set; }
    public string FileName { get; set; }
    public string Drive { get; set; }
    public string Genre { get; set; }
}
