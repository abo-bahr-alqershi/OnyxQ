using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SaleCouponDetail Identifier Value Object
/// </summary>
public sealed class SaleCouponDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SaleCouponDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SaleCouponDetailId instance
    /// </summary>
    public SaleCouponDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SaleCouponDetailId with a new GUID
    /// </summary>
    public static SaleCouponDetailId CreateUnique()
    {
        return new SaleCouponDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SaleCouponDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SaleCouponDetailId id) => id.Value;
}
}
