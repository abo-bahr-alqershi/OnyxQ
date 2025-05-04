using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorLimitPurchase Identifier Value Object
/// </summary>
public sealed class VendorLimitPurchaseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorLimitPurchase
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorLimitPurchaseId instance
    /// </summary>
    public VendorLimitPurchaseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorLimitPurchaseId with a new GUID
    /// </summary>
    public static VendorLimitPurchaseId CreateUnique()
    {
        return new VendorLimitPurchaseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorLimitPurchaseId id) => id.Value.ToString();
    public static implicit operator Guid(VendorLimitPurchaseId id) => id.Value;
}
}
