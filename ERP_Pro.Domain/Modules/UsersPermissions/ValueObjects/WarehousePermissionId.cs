using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// WarehousePermission Identifier Value Object
/// </summary>
public sealed class WarehousePermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehousePermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehousePermissionId instance
    /// </summary>
    public WarehousePermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehousePermissionId with a new GUID
    /// </summary>
    public static WarehousePermissionId CreateUnique()
    {
        return new WarehousePermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehousePermissionId id) => id.Value.ToString();
    public static implicit operator Guid(WarehousePermissionId id) => id.Value;
}
}
