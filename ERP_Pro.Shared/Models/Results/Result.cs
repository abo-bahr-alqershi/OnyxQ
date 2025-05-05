using System.Collections.Generic;
using System.Linq;

namespace ERP_Pro.Shared.Models.Results;

public class Result : IResult
{
    public bool Succeeded { get; protected set; }
    public string[] Messages { get; protected set; }
    public IDictionary<string, string[]>? Errors { get; protected set; }

    protected Result()
    {
        Succeeded = true;
        Messages = Array.Empty<string>();
    }

    protected Result(bool succeeded, IEnumerable<string> messages)
    {
        Succeeded = succeeded;
        Messages = messages.ToArray();
    }

    protected Result(bool succeeded, IEnumerable<string> messages, IDictionary<string, string[]> errors)
    {
        Succeeded = succeeded;
        Messages = messages.ToArray();
        Errors = errors;
    }

    public static Result Success()
    {
        return new Result();
    }

    public static Result Success(string message)
    {
        return new Result(true, new[] { message });
    }

    public static Result Success(IEnumerable<string> messages)
    {
        return new Result(true, messages);
    }

    public static Result Failure()
    {
        return new Result(false, Array.Empty<string>());
    }

    public static Result Failure(string message)
    {
        return new Result(false, new[] { message });
    }

    public static Result Failure(IEnumerable<string> messages)
    {
        return new Result(false, messages);
    }

    public static Result Failure(IDictionary<string, string[]> errors)
    {
        return new Result(false, Array.Empty<string>(), errors);
    }

    public static Result Failure(string message, IDictionary<string, string[]> errors)
    {
        return new Result(false, new[] { message }, errors);
    }

    public static Result Failure(IEnumerable<string> messages, IDictionary<string, string[]> errors)
    {
        return new Result(false, messages, errors);
    }
} 