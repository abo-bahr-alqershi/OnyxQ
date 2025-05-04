using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// OutgoingTypePermission Identifier Value Object
/// </summary>
public sealed class OutgoingTypePermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingTypePermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingTypePermissionId instance
    /// </summary>
    public OutgoingTypePermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingTypePermissionId with a new GUID
    /// </summary>
    public static OutgoingTypePermissionId CreateUnique()
    {
        return new OutgoingTypePermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingTypePermissionId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingTypePermissionId id) => id.Value;
}
}
