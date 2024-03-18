namespace MusicLibrary.Common;

public class ProgressArgs
{
    public int FilesProcessed { get; set; }
    public int TotalFiles { get; set; }
    public string? Folder { get; set; }
    public string? Message { get; set; }
}