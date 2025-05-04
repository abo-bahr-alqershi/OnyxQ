using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorClaimItemGroup Identifier Value Object
/// </summary>
public sealed class VendorClaimItemGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorClaimItemGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorClaimItemGroupId instance
    /// </summary>
    public VendorClaimItemGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorClaimItemGroupId with a new GUID
    /// </summary>
    public static VendorClaimItemGroupId CreateUnique()
    {
        return new VendorClaimItemGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorClaimItemGroupId id) => id.Value.ToString();
    public static implicit operator Guid(VendorClaimItemGroupId id) => id.Value;
}
}
