using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorItem Identifier Value Object
/// </summary>
public sealed class VendorItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorItemId instance
    /// </summary>
    public VendorItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorItemId with a new GUID
    /// </summary>
    public static VendorItemId CreateUnique()
    {
        return new VendorItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorItemId id) => id.Value.ToString();
    public static implicit operator Guid(VendorItemId id) => id.Value;
}
}
