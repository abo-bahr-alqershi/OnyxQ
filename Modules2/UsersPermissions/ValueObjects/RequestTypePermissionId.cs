using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// RequestTypePermission Identifier Value Object
/// </summary>
public sealed class RequestTypePermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestTypePermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestTypePermissionId instance
    /// </summary>
    public RequestTypePermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestTypePermissionId with a new GUID
    /// </summary>
    public static RequestTypePermissionId CreateUnique()
    {
        return new RequestTypePermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestTypePermissionId id) => id.Value.ToString();
    public static implicit operator Guid(RequestTypePermissionId id) => id.Value;
}
}
