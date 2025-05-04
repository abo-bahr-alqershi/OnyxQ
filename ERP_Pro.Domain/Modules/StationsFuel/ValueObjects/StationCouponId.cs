using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCoupon Identifier Value Object
/// </summary>
public sealed class StationCouponId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCoupon
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCouponId instance
    /// </summary>
    public StationCouponId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCouponId with a new GUID
    /// </summary>
    public static StationCouponId CreateUnique()
    {
        return new StationCouponId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCouponId id) => id.Value.ToString();
    public static implicit operator Guid(StationCouponId id) => id.Value;
}
}
