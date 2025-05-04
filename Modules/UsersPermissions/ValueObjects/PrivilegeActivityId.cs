using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeActivity Identifier Value Object
/// </summary>
public sealed class PrivilegeActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeActivityId instance
    /// </summary>
    public PrivilegeActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeActivityId with a new GUID
    /// </summary>
    public static PrivilegeActivityId CreateUnique()
    {
        return new PrivilegeActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeActivityId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeActivityId id) => id.Value;
}
}
