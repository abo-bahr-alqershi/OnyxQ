using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorPriceListMaster Identifier Value Object
/// </summary>
public sealed class VendorPriceListMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorPriceListMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorPriceListMasterId instance
    /// </summary>
    public VendorPriceListMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorPriceListMasterId with a new GUID
    /// </summary>
    public static VendorPriceListMasterId CreateUnique()
    {
        return new VendorPriceListMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorPriceListMasterId id) => id.Value.ToString();
    public static implicit operator Guid(VendorPriceListMasterId id) => id.Value;
}
}
