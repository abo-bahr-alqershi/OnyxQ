using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AccountsReceivableType Identifier Value Object
/// </summary>
public sealed class AccountsReceivableTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableTypeId instance
    /// </summary>
    public AccountsReceivableTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableTypeId with a new GUID
    /// </summary>
    public static AccountsReceivableTypeId CreateUnique()
    {
        return new AccountsReceivableTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableTypeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableTypeId id) => id.Value;
}
}
