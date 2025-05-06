using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationPeriod Identifier Value Object
/// </summary>
public sealed class StationPeriodId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationPeriod
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationPeriodId instance
    /// </summary>
    public StationPeriodId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationPeriodId with a new GUID
    /// </summary>
    public static StationPeriodId CreateUnique()
    {
        return new StationPeriodId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationPeriodId id) => id.Value.ToString();
    public static implicit operator Guid(StationPeriodId id) => id.Value;
}
}
