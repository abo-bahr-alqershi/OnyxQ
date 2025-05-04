using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationBillCoupon Identifier Value Object
/// </summary>
public sealed class StationBillCouponId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationBillCoupon
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationBillCouponId instance
    /// </summary>
    public StationBillCouponId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationBillCouponId with a new GUID
    /// </summary>
    public static StationBillCouponId CreateUnique()
    {
        return new StationBillCouponId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationBillCouponId id) => id.Value.ToString();
    public static implicit operator Guid(StationBillCouponId id) => id.Value;
}
}
