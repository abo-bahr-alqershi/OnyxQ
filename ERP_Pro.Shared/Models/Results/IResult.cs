namespace ERP_Pro.Shared.Models.Results;

public interface IResult
{
    bool Succeeded { get; }
    string[] Messages { get; }
    IDictionary<string, string[]>? Errors { get; }
} 