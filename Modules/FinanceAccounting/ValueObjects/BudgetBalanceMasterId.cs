using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BudgetBalanceMaster Identifier Value Object
/// </summary>
public sealed class BudgetBalanceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BudgetBalanceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BudgetBalanceMasterId instance
    /// </summary>
    public BudgetBalanceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BudgetBalanceMasterId with a new GUID
    /// </summary>
    public static BudgetBalanceMasterId CreateUnique()
    {
        return new BudgetBalanceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BudgetBalanceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BudgetBalanceMasterId id) => id.Value;
}
}
