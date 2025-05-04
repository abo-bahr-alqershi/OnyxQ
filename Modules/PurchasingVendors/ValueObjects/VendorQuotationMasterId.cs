using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorQuotationMaster Identifier Value Object
/// </summary>
public sealed class VendorQuotationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorQuotationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorQuotationMasterId instance
    /// </summary>
    public VendorQuotationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorQuotationMasterId with a new GUID
    /// </summary>
    public static VendorQuotationMasterId CreateUnique()
    {
        return new VendorQuotationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorQuotationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(VendorQuotationMasterId id) => id.Value;
}
}
