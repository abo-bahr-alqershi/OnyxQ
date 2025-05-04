using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// PeriodDetail Identifier Value Object
/// </summary>
public sealed class PeriodDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodDetailId instance
    /// </summary>
    public PeriodDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodDetailId with a new GUID
    /// </summary>
    public static PeriodDetailId CreateUnique()
    {
        return new PeriodDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodDetailId id) => id.Value;
}
}
