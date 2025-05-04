using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// Account Identifier Value Object
/// </summary>
public sealed class AccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Account
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountId instance
    /// </summary>
    public AccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountId with a new GUID
    /// </summary>
    public static AccountId CreateUnique()
    {
        return new AccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountId id) => id.Value.ToString();
    public static implicit operator Guid(AccountId id) => id.Value;
}
}
