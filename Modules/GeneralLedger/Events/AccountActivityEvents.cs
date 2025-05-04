using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountActivity entity
/// </summary>
public sealed class AccountActivityCreatedEvent : DomainEvent
{
    public AccountActivityId AccountActivityId { get; }

    public AccountActivityCreatedEvent(AccountActivityId accountactivityId)
    {
        AccountActivityId = accountactivityId;
    }
}

public sealed class AccountActivityUpdatedEvent : DomainEvent
{
    public AccountActivityId AccountActivityId { get; }

    public AccountActivityUpdatedEvent(AccountActivityId accountactivityId)
    {
        AccountActivityId = accountactivityId;
    }
}

public sealed class AccountActivityDeletedEvent : DomainEvent
{
    public AccountActivityId AccountActivityId { get; }

    public AccountActivityDeletedEvent(AccountActivityId accountactivityId)
    {
        AccountActivityId = accountactivityId;
    }
}
}
