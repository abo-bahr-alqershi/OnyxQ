using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountCurrency Identifier Value Object
/// </summary>
public sealed class AccountCurrencyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountCurrency
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountCurrencyId instance
    /// </summary>
    public AccountCurrencyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountCurrencyId with a new GUID
    /// </summary>
    public static AccountCurrencyId CreateUnique()
    {
        return new AccountCurrencyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountCurrencyId id) => id.Value.ToString();
    public static implicit operator Guid(AccountCurrencyId id) => id.Value;
}
}
