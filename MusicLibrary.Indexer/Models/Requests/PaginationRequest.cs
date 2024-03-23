namespace MusicLibrary.Indexer.Models;

public struct PaginationRequest
{
    public PaginationRequest(int pageSize, int pageIndex)
    {
        PageSize = pageSize;
        PageIndex = pageIndex;
    }

    public int PageSize { get; private set; }
    public int PageIndex { get; private set; }
}
