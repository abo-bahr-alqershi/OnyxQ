using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BudgetApprovalRequestFinanceMaster Identifier Value Object
/// </summary>
public sealed class BudgetApprovalRequestFinanceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BudgetApprovalRequestFinanceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BudgetApprovalRequestFinanceMasterId instance
    /// </summary>
    public BudgetApprovalRequestFinanceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BudgetApprovalRequestFinanceMasterId with a new GUID
    /// </summary>
    public static BudgetApprovalRequestFinanceMasterId CreateUnique()
    {
        return new BudgetApprovalRequestFinanceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BudgetApprovalRequestFinanceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BudgetApprovalRequestFinanceMasterId id) => id.Value;
}
}
