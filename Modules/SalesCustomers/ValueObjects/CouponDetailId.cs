using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CouponDetail Identifier Value Object
/// </summary>
public sealed class CouponDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CouponDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CouponDetailId instance
    /// </summary>
    public CouponDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CouponDetailId with a new GUID
    /// </summary>
    public static CouponDetailId CreateUnique()
    {
        return new CouponDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CouponDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CouponDetailId id) => id.Value;
}
}
