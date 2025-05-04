using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesFreeQuantity Identifier Value Object
/// </summary>
public sealed class SalesFreeQuantityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesFreeQuantity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesFreeQuantityId instance
    /// </summary>
    public SalesFreeQuantityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesFreeQuantityId with a new GUID
    /// </summary>
    public static SalesFreeQuantityId CreateUnique()
    {
        return new SalesFreeQuantityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesFreeQuantityId id) => id.Value.ToString();
    public static implicit operator Guid(SalesFreeQuantityId id) => id.Value;
}
}
