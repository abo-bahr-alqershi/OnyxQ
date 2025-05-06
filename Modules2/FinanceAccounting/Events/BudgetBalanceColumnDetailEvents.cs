using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BudgetBalanceColumnDetail entity
/// </summary>
public sealed class BudgetBalanceColumnDetailCreatedEvent : DomainEvent
{
    public BudgetBalanceColumnDetailId BudgetBalanceColumnDetailId { get; }

    public BudgetBalanceColumnDetailCreatedEvent(BudgetBalanceColumnDetailId budgetbalancecolumndetailId)
    {
        BudgetBalanceColumnDetailId = budgetbalancecolumndetailId;
    }
}

public sealed class BudgetBalanceColumnDetailUpdatedEvent : DomainEvent
{
    public BudgetBalanceColumnDetailId BudgetBalanceColumnDetailId { get; }

    public BudgetBalanceColumnDetailUpdatedEvent(BudgetBalanceColumnDetailId budgetbalancecolumndetailId)
    {
        BudgetBalanceColumnDetailId = budgetbalancecolumndetailId;
    }
}

public sealed class BudgetBalanceColumnDetailDeletedEvent : DomainEvent
{
    public BudgetBalanceColumnDetailId BudgetBalanceColumnDetailId { get; }

    public BudgetBalanceColumnDetailDeletedEvent(BudgetBalanceColumnDetailId budgetbalancecolumndetailId)
    {
        BudgetBalanceColumnDetailId = budgetbalancecolumndetailId;
    }
}
}
