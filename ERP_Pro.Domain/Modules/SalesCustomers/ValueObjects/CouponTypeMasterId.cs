using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CouponTypeMaster Identifier Value Object
/// </summary>
public sealed class CouponTypeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CouponTypeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CouponTypeMasterId instance
    /// </summary>
    public CouponTypeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CouponTypeMasterId with a new GUID
    /// </summary>
    public static CouponTypeMasterId CreateUnique()
    {
        return new CouponTypeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CouponTypeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CouponTypeMasterId id) => id.Value;
}
}
