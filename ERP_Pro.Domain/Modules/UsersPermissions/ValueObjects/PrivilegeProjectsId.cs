using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeProjects Identifier Value Object
/// </summary>
public sealed class PrivilegeProjectsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeProjects
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeProjectsId instance
    /// </summary>
    public PrivilegeProjectsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeProjectsId with a new GUID
    /// </summary>
    public static PrivilegeProjectsId CreateUnique()
    {
        return new PrivilegeProjectsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeProjectsId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeProjectsId id) => id.Value;
}
}
