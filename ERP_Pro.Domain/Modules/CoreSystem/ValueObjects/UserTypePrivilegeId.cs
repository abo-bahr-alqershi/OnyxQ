using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// UserTypePrivilege Identifier Value Object
/// </summary>
public sealed class UserTypePrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserTypePrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserTypePrivilegeId instance
    /// </summary>
    public UserTypePrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserTypePrivilegeId with a new GUID
    /// </summary>
    public static UserTypePrivilegeId CreateUnique()
    {
        return new UserTypePrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserTypePrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(UserTypePrivilegeId id) => id.Value;
}
}
