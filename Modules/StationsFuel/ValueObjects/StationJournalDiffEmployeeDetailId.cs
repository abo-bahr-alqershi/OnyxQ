using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationJournalDiffEmployeeDetail Identifier Value Object
/// </summary>
public sealed class StationJournalDiffEmployeeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationJournalDiffEmployeeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationJournalDiffEmployeeDetailId instance
    /// </summary>
    public StationJournalDiffEmployeeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationJournalDiffEmployeeDetailId with a new GUID
    /// </summary>
    public static StationJournalDiffEmployeeDetailId CreateUnique()
    {
        return new StationJournalDiffEmployeeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationJournalDiffEmployeeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationJournalDiffEmployeeDetailId id) => id.Value;
}
}
