using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserCopyAudit Identifier Value Object
/// </summary>
public sealed class UserCopyAuditId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserCopyAudit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserCopyAuditId instance
    /// </summary>
    public UserCopyAuditId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserCopyAuditId with a new GUID
    /// </summary>
    public static UserCopyAuditId CreateUnique()
    {
        return new UserCopyAuditId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserCopyAuditId id) => id.Value.ToString();
    public static implicit operator Guid(UserCopyAuditId id) => id.Value;
}
}
