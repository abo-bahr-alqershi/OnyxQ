using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerEditBudgetBalanceMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerEditBudgetBalanceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerEditBudgetBalanceMasterId instance
    /// </summary>
    public GeneralLedgerEditBudgetBalanceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerEditBudgetBalanceMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerEditBudgetBalanceMasterId CreateUnique()
    {
        return new GeneralLedgerEditBudgetBalanceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerEditBudgetBalanceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerEditBudgetBalanceMasterId id) => id.Value;
}
}
