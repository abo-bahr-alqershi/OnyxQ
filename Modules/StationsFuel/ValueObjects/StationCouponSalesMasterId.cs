using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCouponSalesMaster Identifier Value Object
/// </summary>
public sealed class StationCouponSalesMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCouponSalesMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCouponSalesMasterId instance
    /// </summary>
    public StationCouponSalesMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCouponSalesMasterId with a new GUID
    /// </summary>
    public static StationCouponSalesMasterId CreateUnique()
    {
        return new StationCouponSalesMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCouponSalesMasterId id) => id.Value.ToString();
    public static implicit operator Guid(StationCouponSalesMasterId id) => id.Value;
}
}
