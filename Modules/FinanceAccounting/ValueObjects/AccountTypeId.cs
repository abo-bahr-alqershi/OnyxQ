using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountType Identifier Value Object
/// </summary>
public sealed class AccountTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountTypeId instance
    /// </summary>
    public AccountTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountTypeId with a new GUID
    /// </summary>
    public static AccountTypeId CreateUnique()
    {
        return new AccountTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountTypeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountTypeId id) => id.Value;
}
}
