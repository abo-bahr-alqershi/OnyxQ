using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BudgetBalanceColumnDetail Identifier Value Object
/// </summary>
public sealed class BudgetBalanceColumnDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BudgetBalanceColumnDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BudgetBalanceColumnDetailId instance
    /// </summary>
    public BudgetBalanceColumnDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BudgetBalanceColumnDetailId with a new GUID
    /// </summary>
    public static BudgetBalanceColumnDetailId CreateUnique()
    {
        return new BudgetBalanceColumnDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BudgetBalanceColumnDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BudgetBalanceColumnDetailId id) => id.Value;
}
}
