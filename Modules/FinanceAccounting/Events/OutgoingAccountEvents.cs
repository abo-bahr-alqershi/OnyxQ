using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to OutgoingAccount entity
/// </summary>
public sealed class OutgoingAccountCreatedEvent : DomainEvent
{
    public OutgoingAccountId OutgoingAccountId { get; }

    public OutgoingAccountCreatedEvent(OutgoingAccountId outgoingaccountId)
    {
        OutgoingAccountId = outgoingaccountId;
    }
}

public sealed class OutgoingAccountUpdatedEvent : DomainEvent
{
    public OutgoingAccountId OutgoingAccountId { get; }

    public OutgoingAccountUpdatedEvent(OutgoingAccountId outgoingaccountId)
    {
        OutgoingAccountId = outgoingaccountId;
    }
}

public sealed class OutgoingAccountDeletedEvent : DomainEvent
{
    public OutgoingAccountId OutgoingAccountId { get; }

    public OutgoingAccountDeletedEvent(OutgoingAccountId outgoingaccountId)
    {
        OutgoingAccountId = outgoingaccountId;
    }
}
}
