using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesCharge Identifier Value Object
/// </summary>
public sealed class SalesChargeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesCharge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesChargeId instance
    /// </summary>
    public SalesChargeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesChargeId with a new GUID
    /// </summary>
    public static SalesChargeId CreateUnique()
    {
        return new SalesChargeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesChargeId id) => id.Value.ToString();
    public static implicit operator Guid(SalesChargeId id) => id.Value;
}
}
