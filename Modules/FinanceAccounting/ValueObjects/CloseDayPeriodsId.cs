using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CloseDayPeriods Identifier Value Object
/// </summary>
public sealed class CloseDayPeriodsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CloseDayPeriods
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CloseDayPeriodsId instance
    /// </summary>
    public CloseDayPeriodsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CloseDayPeriodsId with a new GUID
    /// </summary>
    public static CloseDayPeriodsId CreateUnique()
    {
        return new CloseDayPeriodsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CloseDayPeriodsId id) => id.Value.ToString();
    public static implicit operator Guid(CloseDayPeriodsId id) => id.Value;
}
}
