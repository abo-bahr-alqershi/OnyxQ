using System.Collections.Generic;

namespace ERP_Pro.Shared.Models.Results;

public class PaginatedResult<T> : Result<IReadOnlyList<T>>
{
    public int Page { get; private set; }
    public int TotalPages { get; private set; }
    public int TotalCount { get; private set; }
    public bool HasPreviousPage => Page > 1;
    public bool HasNextPage => Page < TotalPages;

    protected internal PaginatedResult(IReadOnlyList<T> data, int count, int page, int pageSize)
        : base(data)
    {
        Page = page;
        TotalCount = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }

    protected internal PaginatedResult(IReadOnlyList<T> data, int count, int page, int pageSize, string message)
        : base(data, message)
    {
        Page = page;
        TotalCount = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }

    protected internal PaginatedResult(IReadOnlyList<T> data, int count, int page, int pageSize, IEnumerable<string> messages)
        : base(data, messages)
    {
        Page = page;
        TotalCount = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }

    public static PaginatedResult<T> Success(IReadOnlyList<T> data, int count, int page, int pageSize)
    {
        return new PaginatedResult<T>(data, count, page, pageSize);
    }

    public static PaginatedResult<T> Success(IReadOnlyList<T> data, int count, int page, int pageSize, string message)
    {
        return new PaginatedResult<T>(data, count, page, pageSize, message);
    }

    public static PaginatedResult<T> Success(IReadOnlyList<T> data, int count, int page, int pageSize, IEnumerable<string> messages)
    {
        return new PaginatedResult<T>(data, count, page, pageSize, messages);
    }

    public new static PaginatedResult<T> Failure(string message)
    {
        return new PaginatedResult<T>(new List<T>().AsReadOnly(), 0, 0, 1, message);
    }

    public new static PaginatedResult<T> Failure(IEnumerable<string> messages)
    {
        return new PaginatedResult<T>(new List<T>().AsReadOnly(), 0, 0, 1, messages);
    }

    public new static PaginatedResult<T> Failure(IDictionary<string, string[]> errors)
    {
        var result = new PaginatedResult<T>(new List<T>().AsReadOnly(), 0, 0, 1);
        result.Errors = errors;
        result.Succeeded = false;
        return result;
    }
} 