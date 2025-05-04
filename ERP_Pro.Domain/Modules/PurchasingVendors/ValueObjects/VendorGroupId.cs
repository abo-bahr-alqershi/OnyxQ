using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorGroup Identifier Value Object
/// </summary>
public sealed class VendorGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorGroupId instance
    /// </summary>
    public VendorGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorGroupId with a new GUID
    /// </summary>
    public static VendorGroupId CreateUnique()
    {
        return new VendorGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorGroupId id) => id.Value.ToString();
    public static implicit operator Guid(VendorGroupId id) => id.Value;
}
}
