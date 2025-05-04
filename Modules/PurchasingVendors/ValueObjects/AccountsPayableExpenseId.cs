using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableExpense Identifier Value Object
/// </summary>
public sealed class AccountsPayableExpenseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableExpense
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableExpenseId instance
    /// </summary>
    public AccountsPayableExpenseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableExpenseId with a new GUID
    /// </summary>
    public static AccountsPayableExpenseId CreateUnique()
    {
        return new AccountsPayableExpenseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableExpenseId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableExpenseId id) => id.Value;
}
}
