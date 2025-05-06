using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// FixedPermission Identifier Value Object
/// </summary>
public sealed class FixedPermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FixedPermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FixedPermissionId instance
    /// </summary>
    public FixedPermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FixedPermissionId with a new GUID
    /// </summary>
    public static FixedPermissionId CreateUnique()
    {
        return new FixedPermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FixedPermissionId id) => id.Value.ToString();
    public static implicit operator Guid(FixedPermissionId id) => id.Value;
}
}
