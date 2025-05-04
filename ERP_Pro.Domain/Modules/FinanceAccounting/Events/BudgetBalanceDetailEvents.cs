using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BudgetBalanceDetail entity
/// </summary>
public sealed class BudgetBalanceDetailCreatedEvent : DomainEvent
{
    public BudgetBalanceDetailId BudgetBalanceDetailId { get; }

    public BudgetBalanceDetailCreatedEvent(BudgetBalanceDetailId budgetbalancedetailId)
    {
        BudgetBalanceDetailId = budgetbalancedetailId;
    }
}

public sealed class BudgetBalanceDetailUpdatedEvent : DomainEvent
{
    public BudgetBalanceDetailId BudgetBalanceDetailId { get; }

    public BudgetBalanceDetailUpdatedEvent(BudgetBalanceDetailId budgetbalancedetailId)
    {
        BudgetBalanceDetailId = budgetbalancedetailId;
    }
}

public sealed class BudgetBalanceDetailDeletedEvent : DomainEvent
{
    public BudgetBalanceDetailId BudgetBalanceDetailId { get; }

    public BudgetBalanceDetailDeletedEvent(BudgetBalanceDetailId budgetbalancedetailId)
    {
        BudgetBalanceDetailId = budgetbalancedetailId;
    }
}
}
