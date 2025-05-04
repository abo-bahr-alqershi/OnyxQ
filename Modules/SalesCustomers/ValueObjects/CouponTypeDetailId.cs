using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CouponTypeDetail Identifier Value Object
/// </summary>
public sealed class CouponTypeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CouponTypeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CouponTypeDetailId instance
    /// </summary>
    public CouponTypeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CouponTypeDetailId with a new GUID
    /// </summary>
    public static CouponTypeDetailId CreateUnique()
    {
        return new CouponTypeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CouponTypeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CouponTypeDetailId id) => id.Value;
}
}
