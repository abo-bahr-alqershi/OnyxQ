using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CheckIncomeDetail entity
/// </summary>
public sealed class CheckIncomeDetailCreatedEvent : DomainEvent
{
    public CheckIncomeDetailId CheckIncomeDetailId { get; }

    public CheckIncomeDetailCreatedEvent(CheckIncomeDetailId checkincomedetailId)
    {
        CheckIncomeDetailId = checkincomedetailId;
    }
}

public sealed class CheckIncomeDetailUpdatedEvent : DomainEvent
{
    public CheckIncomeDetailId CheckIncomeDetailId { get; }

    public CheckIncomeDetailUpdatedEvent(CheckIncomeDetailId checkincomedetailId)
    {
        CheckIncomeDetailId = checkincomedetailId;
    }
}

public sealed class CheckIncomeDetailDeletedEvent : DomainEvent
{
    public CheckIncomeDetailId CheckIncomeDetailId { get; }

    public CheckIncomeDetailDeletedEvent(CheckIncomeDetailId checkincomedetailId)
    {
        CheckIncomeDetailId = checkincomedetailId;
    }
}
}
