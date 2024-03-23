namespace MusicLibrary.Indexer.Models.Dto;

public struct PaginationDto
{
    public PaginationDto(int pageSize, int pageIndex, int totalPages)
    {
        PageSize = pageSize;
        PageIndex = pageIndex;
        TotalPages = totalPages;
    }

    public int PageSize { get; private set; }
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }
}
