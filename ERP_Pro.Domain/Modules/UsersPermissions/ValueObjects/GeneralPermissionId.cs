using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// GeneralPermission Identifier Value Object
/// </summary>
public sealed class GeneralPermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralPermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralPermissionId instance
    /// </summary>
    public GeneralPermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralPermissionId with a new GUID
    /// </summary>
    public static GeneralPermissionId CreateUnique()
    {
        return new GeneralPermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralPermissionId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralPermissionId id) => id.Value;
}
}
