using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// ItemActivityPrivilege Identifier Value Object
/// </summary>
public sealed class ItemActivityPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemActivityPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemActivityPrivilegeId instance
    /// </summary>
    public ItemActivityPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemActivityPrivilegeId with a new GUID
    /// </summary>
    public static ItemActivityPrivilegeId CreateUnique()
    {
        return new ItemActivityPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemActivityPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(ItemActivityPrivilegeId id) => id.Value;
}
}
