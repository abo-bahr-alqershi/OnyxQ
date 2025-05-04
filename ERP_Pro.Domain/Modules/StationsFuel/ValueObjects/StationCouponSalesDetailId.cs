using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCouponSalesDetail Identifier Value Object
/// </summary>
public sealed class StationCouponSalesDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCouponSalesDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCouponSalesDetailId instance
    /// </summary>
    public StationCouponSalesDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCouponSalesDetailId with a new GUID
    /// </summary>
    public static StationCouponSalesDetailId CreateUnique()
    {
        return new StationCouponSalesDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCouponSalesDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationCouponSalesDetailId id) => id.Value;
}
}
