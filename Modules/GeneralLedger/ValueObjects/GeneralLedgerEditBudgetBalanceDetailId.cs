using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerEditBudgetBalanceDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerEditBudgetBalanceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerEditBudgetBalanceDetailId instance
    /// </summary>
    public GeneralLedgerEditBudgetBalanceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerEditBudgetBalanceDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerEditBudgetBalanceDetailId CreateUnique()
    {
        return new GeneralLedgerEditBudgetBalanceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerEditBudgetBalanceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerEditBudgetBalanceDetailId id) => id.Value;
}
}
