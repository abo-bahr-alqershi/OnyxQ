using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorPriceListDetail Identifier Value Object
/// </summary>
public sealed class VendorPriceListDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorPriceListDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorPriceListDetailId instance
    /// </summary>
    public VendorPriceListDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorPriceListDetailId with a new GUID
    /// </summary>
    public static VendorPriceListDetailId CreateUnique()
    {
        return new VendorPriceListDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorPriceListDetailId id) => id.Value.ToString();
    public static implicit operator Guid(VendorPriceListDetailId id) => id.Value;
}
}
