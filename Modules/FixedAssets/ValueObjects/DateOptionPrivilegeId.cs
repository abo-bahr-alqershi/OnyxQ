using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FixedAssets.ValueObjects
{
/// <summary>
/// DateOptionPrivilege Identifier Value Object
/// </summary>
public sealed class DateOptionPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DateOptionPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DateOptionPrivilegeId instance
    /// </summary>
    public DateOptionPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DateOptionPrivilegeId with a new GUID
    /// </summary>
    public static DateOptionPrivilegeId CreateUnique()
    {
        return new DateOptionPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DateOptionPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(DateOptionPrivilegeId id) => id.Value;
}
}
