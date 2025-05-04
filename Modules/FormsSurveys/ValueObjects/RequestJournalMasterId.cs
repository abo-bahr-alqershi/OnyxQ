using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestJournalMaster Identifier Value Object
/// </summary>
public sealed class RequestJournalMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestJournalMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestJournalMasterId instance
    /// </summary>
    public RequestJournalMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestJournalMasterId with a new GUID
    /// </summary>
    public static RequestJournalMasterId CreateUnique()
    {
        return new RequestJournalMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestJournalMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RequestJournalMasterId id) => id.Value;
}
}
