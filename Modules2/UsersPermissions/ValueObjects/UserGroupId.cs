using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserGroup Identifier Value Object
/// </summary>
public sealed class UserGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserGroupId instance
    /// </summary>
    public UserGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserGroupId with a new GUID
    /// </summary>
    public static UserGroupId CreateUnique()
    {
        return new UserGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserGroupId id) => id.Value.ToString();
    public static implicit operator Guid(UserGroupId id) => id.Value;
}
}
