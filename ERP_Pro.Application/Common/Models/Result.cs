namespace ERP_Pro.Application.Common.Models;

public class Result<T>
{
    public bool Succeeded { get; private set; }
    public T? Data { get; private set; }
    public string? Message { get; private set; }
    public IDictionary<string, string[]>? Errors { get; private set; }

    private Result(bool succeeded, T? data = default, string? message = null, IDictionary<string, string[]>? errors = null)
    {
        Succeeded = succeeded;
        Data = data;
        Message = message;
        Errors = errors;
    }

    public static Result<T> Success(T data, string? message = null)
    {
        return new Result<T>(true, data, message);
    }

    public static Result<T> Failure(string message, IDictionary<string, string[]>? errors = null)
    {
        return new Result<T>(false, default, message, errors);
    }

    public static Result<T> Failure(IDictionary<string, string[]> errors)
    {
        return new Result<T>(false, default, null, errors);
    }
}

public class Result
{
    public bool Succeeded { get; private set; }
    public string? Message { get; private set; }
    public IDictionary<string, string[]>? Errors { get; private set; }

    private Result(bool succeeded, string? message = null, IDictionary<string, string[]>? errors = null)
    {
        Succeeded = succeeded;
        Message = message;
        Errors = errors;
    }

    public static Result Success(string? message = null)
    {
        return new Result(true, message);
    }

    public static Result Failure(string message, IDictionary<string, string[]>? errors = null)
    {
        return new Result(false, message, errors);
    }

    public static Result Failure(IDictionary<string, string[]> errors)
    {
        return new Result(false, null, errors);
    }
} 