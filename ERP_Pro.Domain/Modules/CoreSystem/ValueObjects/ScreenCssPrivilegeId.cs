using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ScreenCssPrivilege Identifier Value Object
/// </summary>
public sealed class ScreenCssPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScreenCssPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScreenCssPrivilegeId instance
    /// </summary>
    public ScreenCssPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScreenCssPrivilegeId with a new GUID
    /// </summary>
    public static ScreenCssPrivilegeId CreateUnique()
    {
        return new ScreenCssPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScreenCssPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(ScreenCssPrivilegeId id) => id.Value;
}
}
