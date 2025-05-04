using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BudgetApprovalRequestFinanceDetail entity
/// </summary>
public sealed class BudgetApprovalRequestFinanceDetailCreatedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceDetailId BudgetApprovalRequestFinanceDetailId { get; }

    public BudgetApprovalRequestFinanceDetailCreatedEvent(BudgetApprovalRequestFinanceDetailId budgetapprovalrequestfinancedetailId)
    {
        BudgetApprovalRequestFinanceDetailId = budgetapprovalrequestfinancedetailId;
    }
}

public sealed class BudgetApprovalRequestFinanceDetailUpdatedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceDetailId BudgetApprovalRequestFinanceDetailId { get; }

    public BudgetApprovalRequestFinanceDetailUpdatedEvent(BudgetApprovalRequestFinanceDetailId budgetapprovalrequestfinancedetailId)
    {
        BudgetApprovalRequestFinanceDetailId = budgetapprovalrequestfinancedetailId;
    }
}

public sealed class BudgetApprovalRequestFinanceDetailDeletedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceDetailId BudgetApprovalRequestFinanceDetailId { get; }

    public BudgetApprovalRequestFinanceDetailDeletedEvent(BudgetApprovalRequestFinanceDetailId budgetapprovalrequestfinancedetailId)
    {
        BudgetApprovalRequestFinanceDetailId = budgetapprovalrequestfinancedetailId;
    }
}
}
