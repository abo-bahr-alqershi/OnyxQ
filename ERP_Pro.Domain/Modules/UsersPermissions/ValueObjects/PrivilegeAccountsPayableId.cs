using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeAccountsPayable Identifier Value Object
/// </summary>
public sealed class PrivilegeAccountsPayableId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeAccountsPayable
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeAccountsPayableId instance
    /// </summary>
    public PrivilegeAccountsPayableId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeAccountsPayableId with a new GUID
    /// </summary>
    public static PrivilegeAccountsPayableId CreateUnique()
    {
        return new PrivilegeAccountsPayableId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeAccountsPayableId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeAccountsPayableId id) => id.Value;
}
}
