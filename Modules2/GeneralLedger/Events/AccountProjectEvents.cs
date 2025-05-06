using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountProject entity
/// </summary>
public sealed class AccountProjectCreatedEvent : DomainEvent
{
    public AccountProjectId AccountProjectId { get; }

    public AccountProjectCreatedEvent(AccountProjectId accountprojectId)
    {
        AccountProjectId = accountprojectId;
    }
}

public sealed class AccountProjectUpdatedEvent : DomainEvent
{
    public AccountProjectId AccountProjectId { get; }

    public AccountProjectUpdatedEvent(AccountProjectId accountprojectId)
    {
        AccountProjectId = accountprojectId;
    }
}

public sealed class AccountProjectDeletedEvent : DomainEvent
{
    public AccountProjectId AccountProjectId { get; }

    public AccountProjectDeletedEvent(AccountProjectId accountprojectId)
    {
        AccountProjectId = accountprojectId;
    }
}
}
