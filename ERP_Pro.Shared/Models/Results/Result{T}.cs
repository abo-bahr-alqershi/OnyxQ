using System.Collections.Generic;
using System.Linq;

namespace ERP_Pro.Shared.Models.Results;

public class Result<T> : Result, IResult<T>
{
    public T? Data { get; private set; }

    protected internal Result(T? data)
        : base(true, Array.Empty<string>())
    {
        Data = data;
    }

    protected internal Result(T? data, string message)
        : base(true, new[] { message })
    {
        Data = data;
    }

    protected internal Result(T? data, IEnumerable<string> messages)
        : base(true, messages)
    {
        Data = data;
    }

    protected internal Result(string error)
        : base(false, new[] { error })
    {
        Data = default;
    }

    protected internal Result(IEnumerable<string> errors)
        : base(false, errors)
    {
        Data = default;
    }

    protected internal Result(IDictionary<string, string[]> errors)
        : base(false, Array.Empty<string>(), errors)
    {
        Data = default;
    }

    protected internal Result(string error, IDictionary<string, string[]> validationErrors)
        : base(false, new[] { error }, validationErrors)
    {
        Data = default;
    }

    protected internal Result(IEnumerable<string> errors, IDictionary<string, string[]> validationErrors)
        : base(false, errors, validationErrors)
    {
        Data = default;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(data);
    }

    public static Result<T> Success(T data, string message)
    {
        return new Result<T>(data, message);
    }

    public static Result<T> Success(T data, IEnumerable<string> messages)
    {
        return new Result<T>(data, messages);
    }

    public new static Result<T> Failure(string error)
    {
        return new Result<T>(error);
    }

    public new static Result<T> Failure(IEnumerable<string> errors)
    {
        return new Result<T>(errors);
    }

    public new static Result<T> Failure(IDictionary<string, string[]> errors)
    {
        return new Result<T>(errors);
    }

    public new static Result<T> Failure(string error, IDictionary<string, string[]> validationErrors)
    {
        return new Result<T>(error, validationErrors);
    }

    public new static Result<T> Failure(IEnumerable<string> errors, IDictionary<string, string[]> validationErrors)
    {
        return new Result<T>(errors, validationErrors);
    }
} 