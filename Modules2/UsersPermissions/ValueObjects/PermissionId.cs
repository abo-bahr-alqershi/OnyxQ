using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// Permission Identifier Value Object
/// </summary>
public sealed class PermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Permission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PermissionId instance
    /// </summary>
    public PermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PermissionId with a new GUID
    /// </summary>
    public static PermissionId CreateUnique()
    {
        return new PermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PermissionId id) => id.Value.ToString();
    public static implicit operator Guid(PermissionId id) => id.Value;
}
}
