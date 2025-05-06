using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorClaimMaster Identifier Value Object
/// </summary>
public sealed class VendorClaimMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorClaimMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorClaimMasterId instance
    /// </summary>
    public VendorClaimMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorClaimMasterId with a new GUID
    /// </summary>
    public static VendorClaimMasterId CreateUnique()
    {
        return new VendorClaimMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorClaimMasterId id) => id.Value.ToString();
    public static implicit operator Guid(VendorClaimMasterId id) => id.Value;
}
}
