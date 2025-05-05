namespace ERP_Pro.Shared.Models.Results;

public interface IResult<out T> : IResult
{
    T? Data { get; }
} 