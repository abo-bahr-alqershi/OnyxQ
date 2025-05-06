using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserArticlePrivilege Identifier Value Object
/// </summary>
public sealed class UserArticlePrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserArticlePrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserArticlePrivilegeId instance
    /// </summary>
    public UserArticlePrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserArticlePrivilegeId with a new GUID
    /// </summary>
    public static UserArticlePrivilegeId CreateUnique()
    {
        return new UserArticlePrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserArticlePrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(UserArticlePrivilegeId id) => id.Value;
}
}
