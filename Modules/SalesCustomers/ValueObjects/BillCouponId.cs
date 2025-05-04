using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillCoupon Identifier Value Object
/// </summary>
public sealed class BillCouponId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillCoupon
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillCouponId instance
    /// </summary>
    public BillCouponId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillCouponId with a new GUID
    /// </summary>
    public static BillCouponId CreateUnique()
    {
        return new BillCouponId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillCouponId id) => id.Value.ToString();
    public static implicit operator Guid(BillCouponId id) => id.Value;
}
}
