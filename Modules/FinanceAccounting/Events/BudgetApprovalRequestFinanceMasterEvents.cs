using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BudgetApprovalRequestFinanceMaster entity
/// </summary>
public sealed class BudgetApprovalRequestFinanceMasterCreatedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceMasterId BudgetApprovalRequestFinanceMasterId { get; }

    public BudgetApprovalRequestFinanceMasterCreatedEvent(BudgetApprovalRequestFinanceMasterId budgetapprovalrequestfinancemasterId)
    {
        BudgetApprovalRequestFinanceMasterId = budgetapprovalrequestfinancemasterId;
    }
}

public sealed class BudgetApprovalRequestFinanceMasterUpdatedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceMasterId BudgetApprovalRequestFinanceMasterId { get; }

    public BudgetApprovalRequestFinanceMasterUpdatedEvent(BudgetApprovalRequestFinanceMasterId budgetapprovalrequestfinancemasterId)
    {
        BudgetApprovalRequestFinanceMasterId = budgetapprovalrequestfinancemasterId;
    }
}

public sealed class BudgetApprovalRequestFinanceMasterDeletedEvent : DomainEvent
{
    public BudgetApprovalRequestFinanceMasterId BudgetApprovalRequestFinanceMasterId { get; }

    public BudgetApprovalRequestFinanceMasterDeletedEvent(BudgetApprovalRequestFinanceMasterId budgetapprovalrequestfinancemasterId)
    {
        BudgetApprovalRequestFinanceMasterId = budgetapprovalrequestfinancemasterId;
    }
}
}
