using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CouponMaster Identifier Value Object
/// </summary>
public sealed class CouponMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CouponMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CouponMasterId instance
    /// </summary>
    public CouponMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CouponMasterId with a new GUID
    /// </summary>
    public static CouponMasterId CreateUnique()
    {
        return new CouponMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CouponMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CouponMasterId id) => id.Value;
}
}
