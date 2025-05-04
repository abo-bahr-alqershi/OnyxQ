using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SystemFlagPrivilege Identifier Value Object
/// </summary>
public sealed class SystemFlagPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SystemFlagPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SystemFlagPrivilegeId instance
    /// </summary>
    public SystemFlagPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SystemFlagPrivilegeId with a new GUID
    /// </summary>
    public static SystemFlagPrivilegeId CreateUnique()
    {
        return new SystemFlagPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SystemFlagPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(SystemFlagPrivilegeId id) => id.Value;
}
}
