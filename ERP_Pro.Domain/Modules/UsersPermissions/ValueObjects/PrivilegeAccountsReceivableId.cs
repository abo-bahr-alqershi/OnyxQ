using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeAccountsReceivable Identifier Value Object
/// </summary>
public sealed class PrivilegeAccountsReceivableId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeAccountsReceivable
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeAccountsReceivableId instance
    /// </summary>
    public PrivilegeAccountsReceivableId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeAccountsReceivableId with a new GUID
    /// </summary>
    public static PrivilegeAccountsReceivableId CreateUnique()
    {
        return new PrivilegeAccountsReceivableId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeAccountsReceivableId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeAccountsReceivableId id) => id.Value;
}
}
