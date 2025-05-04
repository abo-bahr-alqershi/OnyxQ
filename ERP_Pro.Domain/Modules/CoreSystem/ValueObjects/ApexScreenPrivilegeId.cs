using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApexScreenPrivilege Identifier Value Object
/// </summary>
public sealed class ApexScreenPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApexScreenPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApexScreenPrivilegeId instance
    /// </summary>
    public ApexScreenPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApexScreenPrivilegeId with a new GUID
    /// </summary>
    public static ApexScreenPrivilegeId CreateUnique()
    {
        return new ApexScreenPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApexScreenPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(ApexScreenPrivilegeId id) => id.Value;
}
}
