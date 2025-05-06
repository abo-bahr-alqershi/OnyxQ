using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DistributorCouponMaster Identifier Value Object
/// </summary>
public sealed class DistributorCouponMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DistributorCouponMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DistributorCouponMasterId instance
    /// </summary>
    public DistributorCouponMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DistributorCouponMasterId with a new GUID
    /// </summary>
    public static DistributorCouponMasterId CreateUnique()
    {
        return new DistributorCouponMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DistributorCouponMasterId id) => id.Value.ToString();
    public static implicit operator Guid(DistributorCouponMasterId id) => id.Value;
}
}
