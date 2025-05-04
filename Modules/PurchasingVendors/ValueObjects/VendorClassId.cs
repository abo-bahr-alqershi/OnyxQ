using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorClass Identifier Value Object
/// </summary>
public sealed class VendorClassId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorClass
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorClassId instance
    /// </summary>
    public VendorClassId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorClassId with a new GUID
    /// </summary>
    public static VendorClassId CreateUnique()
    {
        return new VendorClassId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorClassId id) => id.Value.ToString();
    public static implicit operator Guid(VendorClassId id) => id.Value;
}
}
