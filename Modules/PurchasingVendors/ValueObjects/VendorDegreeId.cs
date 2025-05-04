using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// VendorDegree Identifier Value Object
/// </summary>
public sealed class VendorDegreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorDegree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorDegreeId instance
    /// </summary>
    public VendorDegreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorDegreeId with a new GUID
    /// </summary>
    public static VendorDegreeId CreateUnique()
    {
        return new VendorDegreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorDegreeId id) => id.Value.ToString();
    public static implicit operator Guid(VendorDegreeId id) => id.Value;
}
}
