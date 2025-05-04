using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationJournalDiffEmployeeMaster Identifier Value Object
/// </summary>
public sealed class StationJournalDiffEmployeeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationJournalDiffEmployeeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationJournalDiffEmployeeMasterId instance
    /// </summary>
    public StationJournalDiffEmployeeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationJournalDiffEmployeeMasterId with a new GUID
    /// </summary>
    public static StationJournalDiffEmployeeMasterId CreateUnique()
    {
        return new StationJournalDiffEmployeeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationJournalDiffEmployeeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(StationJournalDiffEmployeeMasterId id) => id.Value;
}
}
