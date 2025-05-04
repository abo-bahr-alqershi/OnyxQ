using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// UserAlertSystemPrivilege Identifier Value Object
/// </summary>
public sealed class UserAlertSystemPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserAlertSystemPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserAlertSystemPrivilegeId instance
    /// </summary>
    public UserAlertSystemPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserAlertSystemPrivilegeId with a new GUID
    /// </summary>
    public static UserAlertSystemPrivilegeId CreateUnique()
    {
        return new UserAlertSystemPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserAlertSystemPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(UserAlertSystemPrivilegeId id) => id.Value;
}
}
