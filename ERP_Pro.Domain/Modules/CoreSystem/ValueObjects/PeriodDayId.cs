using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// PeriodDay Identifier Value Object
/// </summary>
public sealed class PeriodDayId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodDay
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodDayId instance
    /// </summary>
    public PeriodDayId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodDayId with a new GUID
    /// </summary>
    public static PeriodDayId CreateUnique()
    {
        return new PeriodDayId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodDayId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodDayId id) => id.Value;
}
}
