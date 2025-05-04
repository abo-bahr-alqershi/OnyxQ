using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BudgetBalanceMaster entity
/// </summary>
public sealed class BudgetBalanceMasterCreatedEvent : DomainEvent
{
    public BudgetBalanceMasterId BudgetBalanceMasterId { get; }

    public BudgetBalanceMasterCreatedEvent(BudgetBalanceMasterId budgetbalancemasterId)
    {
        BudgetBalanceMasterId = budgetbalancemasterId;
    }
}

public sealed class BudgetBalanceMasterUpdatedEvent : DomainEvent
{
    public BudgetBalanceMasterId BudgetBalanceMasterId { get; }

    public BudgetBalanceMasterUpdatedEvent(BudgetBalanceMasterId budgetbalancemasterId)
    {
        BudgetBalanceMasterId = budgetbalancemasterId;
    }
}

public sealed class BudgetBalanceMasterDeletedEvent : DomainEvent
{
    public BudgetBalanceMasterId BudgetBalanceMasterId { get; }

    public BudgetBalanceMasterDeletedEvent(BudgetBalanceMasterId budgetbalancemasterId)
    {
        BudgetBalanceMasterId = budgetbalancemasterId;
    }
}
}
