using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BudgetApprovalRequestFinanceDetail Identifier Value Object
/// </summary>
public sealed class BudgetApprovalRequestFinanceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BudgetApprovalRequestFinanceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BudgetApprovalRequestFinanceDetailId instance
    /// </summary>
    public BudgetApprovalRequestFinanceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BudgetApprovalRequestFinanceDetailId with a new GUID
    /// </summary>
    public static BudgetApprovalRequestFinanceDetailId CreateUnique()
    {
        return new BudgetApprovalRequestFinanceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BudgetApprovalRequestFinanceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BudgetApprovalRequestFinanceDetailId id) => id.Value;
}
}
