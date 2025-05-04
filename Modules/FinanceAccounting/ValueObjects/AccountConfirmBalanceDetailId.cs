using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountConfirmBalanceDetail Identifier Value Object
/// </summary>
public sealed class AccountConfirmBalanceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountConfirmBalanceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountConfirmBalanceDetailId instance
    /// </summary>
    public AccountConfirmBalanceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountConfirmBalanceDetailId with a new GUID
    /// </summary>
    public static AccountConfirmBalanceDetailId CreateUnique()
    {
        return new AccountConfirmBalanceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountConfirmBalanceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AccountConfirmBalanceDetailId id) => id.Value;
}
}
