using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeVendor Identifier Value Object
/// </summary>
public sealed class PrivilegeVendorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeVendor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeVendorId instance
    /// </summary>
    public PrivilegeVendorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeVendorId with a new GUID
    /// </summary>
    public static PrivilegeVendorId CreateUnique()
    {
        return new PrivilegeVendorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeVendorId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeVendorId id) => id.Value;
}
}
