using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountExpenseDistribution Identifier Value Object
/// </summary>
public sealed class AccountExpenseDistributionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountExpenseDistribution
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountExpenseDistributionId instance
    /// </summary>
    public AccountExpenseDistributionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountExpenseDistributionId with a new GUID
    /// </summary>
    public static AccountExpenseDistributionId CreateUnique()
    {
        return new AccountExpenseDistributionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountExpenseDistributionId id) => id.Value.ToString();
    public static implicit operator Guid(AccountExpenseDistributionId id) => id.Value;
}
}
