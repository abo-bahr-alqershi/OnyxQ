using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesDiscount Identifier Value Object
/// </summary>
public sealed class SalesDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesDiscountId instance
    /// </summary>
    public SalesDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesDiscountId with a new GUID
    /// </summary>
    public static SalesDiscountId CreateUnique()
    {
        return new SalesDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(SalesDiscountId id) => id.Value;
}
}
