using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// PeriodWorkEmployee Identifier Value Object
/// </summary>
public sealed class PeriodWorkEmployeeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodWorkEmployee
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodWorkEmployeeId instance
    /// </summary>
    public PeriodWorkEmployeeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodWorkEmployeeId with a new GUID
    /// </summary>
    public static PeriodWorkEmployeeId CreateUnique()
    {
        return new PeriodWorkEmployeeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodWorkEmployeeId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodWorkEmployeeId id) => id.Value;
}
}
