using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to HandCash entity
/// </summary>
public sealed class HandCashCreatedEvent : DomainEvent
{
    public HandCashId HandCashId { get; }

    public HandCashCreatedEvent(HandCashId handcashId)
    {
        HandCashId = handcashId;
    }
}

public sealed class HandCashUpdatedEvent : DomainEvent
{
    public HandCashId HandCashId { get; }

    public HandCashUpdatedEvent(HandCashId handcashId)
    {
        HandCashId = handcashId;
    }
}

public sealed class HandCashDeletedEvent : DomainEvent
{
    public HandCashId HandCashId { get; }

    public HandCashDeletedEvent(HandCashId handcashId)
    {
        HandCashId = handcashId;
    }
}
}
