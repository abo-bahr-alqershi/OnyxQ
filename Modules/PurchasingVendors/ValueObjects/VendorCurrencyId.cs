using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorCurrency Identifier Value Object
/// </summary>
public sealed class VendorCurrencyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorCurrency
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorCurrencyId instance
    /// </summary>
    public VendorCurrencyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorCurrencyId with a new GUID
    /// </summary>
    public static VendorCurrencyId CreateUnique()
    {
        return new VendorCurrencyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorCurrencyId id) => id.Value.ToString();
    public static implicit operator Guid(VendorCurrencyId id) => id.Value;
}
}
