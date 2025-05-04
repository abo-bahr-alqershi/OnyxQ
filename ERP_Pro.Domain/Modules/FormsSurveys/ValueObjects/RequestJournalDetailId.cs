using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestJournalDetail Identifier Value Object
/// </summary>
public sealed class RequestJournalDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestJournalDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestJournalDetailId instance
    /// </summary>
    public RequestJournalDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestJournalDetailId with a new GUID
    /// </summary>
    public static RequestJournalDetailId CreateUnique()
    {
        return new RequestJournalDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestJournalDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RequestJournalDetailId id) => id.Value;
}
}
