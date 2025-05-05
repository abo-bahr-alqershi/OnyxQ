namespace ERP_Pro.Shared.DTOs.Base;

public class PaginatedResultDto<T>
{
    public List<T> Data { get; set; } = new();
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public int TotalCount { get; set; }
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < TotalPages;

    public PaginatedResultDto() { }

    public PaginatedResultDto(List<T> data, int count, int pageNumber, int pageSize)
    {
        Data = data;
        TotalCount = count;
        CurrentPage = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }

    public static PaginatedResultDto<T> Create(List<T> data, int count, int pageNumber, int pageSize)
        => new(data, count, pageNumber, pageSize);
} 