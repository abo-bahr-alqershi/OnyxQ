using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// CostCenterPermission Identifier Value Object
/// </summary>
public sealed class CostCenterPermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostCenterPermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostCenterPermissionId instance
    /// </summary>
    public CostCenterPermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostCenterPermissionId with a new GUID
    /// </summary>
    public static CostCenterPermissionId CreateUnique()
    {
        return new CostCenterPermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostCenterPermissionId id) => id.Value.ToString();
    public static implicit operator Guid(CostCenterPermissionId id) => id.Value;
}
}
