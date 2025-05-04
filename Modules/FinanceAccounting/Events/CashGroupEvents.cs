using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashGroup entity
/// </summary>
public sealed class CashGroupCreatedEvent : DomainEvent
{
    public CashGroupId CashGroupId { get; }

    public CashGroupCreatedEvent(CashGroupId cashgroupId)
    {
        CashGroupId = cashgroupId;
    }
}

public sealed class CashGroupUpdatedEvent : DomainEvent
{
    public CashGroupId CashGroupId { get; }

    public CashGroupUpdatedEvent(CashGroupId cashgroupId)
    {
        CashGroupId = cashgroupId;
    }
}

public sealed class CashGroupDeletedEvent : DomainEvent
{
    public CashGroupId CashGroupId { get; }

    public CashGroupDeletedEvent(CashGroupId cashgroupId)
    {
        CashGroupId = cashgroupId;
    }
}
}
