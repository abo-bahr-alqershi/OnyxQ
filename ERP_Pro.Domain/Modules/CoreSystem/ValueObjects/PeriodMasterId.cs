using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// PeriodMaster Identifier Value Object
/// </summary>
public sealed class PeriodMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodMasterId instance
    /// </summary>
    public PeriodMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodMasterId with a new GUID
    /// </summary>
    public static PeriodMasterId CreateUnique()
    {
        return new PeriodMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodMasterId id) => id.Value;
}
}
