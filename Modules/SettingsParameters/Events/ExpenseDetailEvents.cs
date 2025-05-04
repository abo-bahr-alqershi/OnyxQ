using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ExpenseDetail entity
/// </summary>
public sealed class ExpenseDetailCreatedEvent : DomainEvent
{
    public ExpenseDetailId ExpenseDetailId { get; }

    public ExpenseDetailCreatedEvent(ExpenseDetailId expensedetailId)
    {
        ExpenseDetailId = expensedetailId;
    }
}

public sealed class ExpenseDetailUpdatedEvent : DomainEvent
{
    public ExpenseDetailId ExpenseDetailId { get; }

    public ExpenseDetailUpdatedEvent(ExpenseDetailId expensedetailId)
    {
        ExpenseDetailId = expensedetailId;
    }
}

public sealed class ExpenseDetailDeletedEvent : DomainEvent
{
    public ExpenseDetailId ExpenseDetailId { get; }

    public ExpenseDetailDeletedEvent(ExpenseDetailId expensedetailId)
    {
        ExpenseDetailId = expensedetailId;
    }
}
}
