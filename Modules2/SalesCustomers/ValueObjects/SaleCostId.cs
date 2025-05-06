using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SaleCost Identifier Value Object
/// </summary>
public sealed class SaleCostId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SaleCost
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SaleCostId instance
    /// </summary>
    public SaleCostId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SaleCostId with a new GUID
    /// </summary>
    public static SaleCostId CreateUnique()
    {
        return new SaleCostId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SaleCostId id) => id.Value.ToString();
    public static implicit operator Guid(SaleCostId id) => id.Value;
}
}
