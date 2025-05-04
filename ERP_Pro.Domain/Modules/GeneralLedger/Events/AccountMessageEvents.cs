using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountMessage entity
/// </summary>
public sealed class AccountMessageCreatedEvent : DomainEvent
{
    public AccountMessageId AccountMessageId { get; }

    public AccountMessageCreatedEvent(AccountMessageId accountmessageId)
    {
        AccountMessageId = accountmessageId;
    }
}

public sealed class AccountMessageUpdatedEvent : DomainEvent
{
    public AccountMessageId AccountMessageId { get; }

    public AccountMessageUpdatedEvent(AccountMessageId accountmessageId)
    {
        AccountMessageId = accountmessageId;
    }
}

public sealed class AccountMessageDeletedEvent : DomainEvent
{
    public AccountMessageId AccountMessageId { get; }

    public AccountMessageDeletedEvent(AccountMessageId accountmessageId)
    {
        AccountMessageId = accountmessageId;
    }
}
}
