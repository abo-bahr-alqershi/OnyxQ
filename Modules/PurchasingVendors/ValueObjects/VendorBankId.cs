using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorBank Identifier Value Object
/// </summary>
public sealed class VendorBankId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorBank
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorBankId instance
    /// </summary>
    public VendorBankId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorBankId with a new GUID
    /// </summary>
    public static VendorBankId CreateUnique()
    {
        return new VendorBankId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorBankId id) => id.Value.ToString();
    public static implicit operator Guid(VendorBankId id) => id.Value;
}
}
