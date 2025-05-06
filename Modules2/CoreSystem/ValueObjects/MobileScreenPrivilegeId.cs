using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// MobileScreenPrivilege Identifier Value Object
/// </summary>
public sealed class MobileScreenPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MobileScreenPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MobileScreenPrivilegeId instance
    /// </summary>
    public MobileScreenPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MobileScreenPrivilegeId with a new GUID
    /// </summary>
    public static MobileScreenPrivilegeId CreateUnique()
    {
        return new MobileScreenPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MobileScreenPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(MobileScreenPrivilegeId id) => id.Value;
}
}
