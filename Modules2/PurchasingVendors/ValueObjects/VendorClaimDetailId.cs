using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorClaimDetail Identifier Value Object
/// </summary>
public sealed class VendorClaimDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorClaimDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorClaimDetailId instance
    /// </summary>
    public VendorClaimDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorClaimDetailId with a new GUID
    /// </summary>
    public static VendorClaimDetailId CreateUnique()
    {
        return new VendorClaimDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorClaimDetailId id) => id.Value.ToString();
    public static implicit operator Guid(VendorClaimDetailId id) => id.Value;
}
}
