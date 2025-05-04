using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BudgetBalanceDetail Identifier Value Object
/// </summary>
public sealed class BudgetBalanceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BudgetBalanceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BudgetBalanceDetailId instance
    /// </summary>
    public BudgetBalanceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BudgetBalanceDetailId with a new GUID
    /// </summary>
    public static BudgetBalanceDetailId CreateUnique()
    {
        return new BudgetBalanceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BudgetBalanceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BudgetBalanceDetailId id) => id.Value;
}
}
