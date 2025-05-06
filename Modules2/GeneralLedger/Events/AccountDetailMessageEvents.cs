using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountDetailMessage entity
/// </summary>
public sealed class AccountDetailMessageCreatedEvent : DomainEvent
{
    public AccountDetailMessageId AccountDetailMessageId { get; }

    public AccountDetailMessageCreatedEvent(AccountDetailMessageId accountdetailmessageId)
    {
        AccountDetailMessageId = accountdetailmessageId;
    }
}

public sealed class AccountDetailMessageUpdatedEvent : DomainEvent
{
    public AccountDetailMessageId AccountDetailMessageId { get; }

    public AccountDetailMessageUpdatedEvent(AccountDetailMessageId accountdetailmessageId)
    {
        AccountDetailMessageId = accountdetailmessageId;
    }
}

public sealed class AccountDetailMessageDeletedEvent : DomainEvent
{
    public AccountDetailMessageId AccountDetailMessageId { get; }

    public AccountDetailMessageDeletedEvent(AccountDetailMessageId accountdetailmessageId)
    {
        AccountDetailMessageId = accountdetailmessageId;
    }
}
}
