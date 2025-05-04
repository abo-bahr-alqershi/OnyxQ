using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DistributorCouponDetail Identifier Value Object
/// </summary>
public sealed class DistributorCouponDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DistributorCouponDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DistributorCouponDetailId instance
    /// </summary>
    public DistributorCouponDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DistributorCouponDetailId with a new GUID
    /// </summary>
    public static DistributorCouponDetailId CreateUnique()
    {
        return new DistributorCouponDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DistributorCouponDetailId id) => id.Value.ToString();
    public static implicit operator Guid(DistributorCouponDetailId id) => id.Value;
}
}
