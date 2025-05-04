using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorQuotationDetail Identifier Value Object
/// </summary>
public sealed class VendorQuotationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorQuotationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorQuotationDetailId instance
    /// </summary>
    public VendorQuotationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorQuotationDetailId with a new GUID
    /// </summary>
    public static VendorQuotationDetailId CreateUnique()
    {
        return new VendorQuotationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorQuotationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(VendorQuotationDetailId id) => id.Value;
}
}
