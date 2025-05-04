using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserTransactionPrivilege Identifier Value Object
/// </summary>
public sealed class UserTransactionPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserTransactionPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserTransactionPrivilegeId instance
    /// </summary>
    public UserTransactionPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserTransactionPrivilegeId with a new GUID
    /// </summary>
    public static UserTransactionPrivilegeId CreateUnique()
    {
        return new UserTransactionPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserTransactionPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(UserTransactionPrivilegeId id) => id.Value;
}
}
