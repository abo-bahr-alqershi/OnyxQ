using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeInventoryType Identifier Value Object
/// </summary>
public sealed class PrivilegeInventoryTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeInventoryType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeInventoryTypeId instance
    /// </summary>
    public PrivilegeInventoryTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeInventoryTypeId with a new GUID
    /// </summary>
    public static PrivilegeInventoryTypeId CreateUnique()
    {
        return new PrivilegeInventoryTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeInventoryTypeId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeInventoryTypeId id) => id.Value;
}
}
