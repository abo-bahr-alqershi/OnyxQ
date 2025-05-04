using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to IncomingAccount entity
/// </summary>
public sealed class IncomingAccountCreatedEvent : DomainEvent
{
    public IncomingAccountId IncomingAccountId { get; }

    public IncomingAccountCreatedEvent(IncomingAccountId incomingaccountId)
    {
        IncomingAccountId = incomingaccountId;
    }
}

public sealed class IncomingAccountUpdatedEvent : DomainEvent
{
    public IncomingAccountId IncomingAccountId { get; }

    public IncomingAccountUpdatedEvent(IncomingAccountId incomingaccountId)
    {
        IncomingAccountId = incomingaccountId;
    }
}

public sealed class IncomingAccountDeletedEvent : DomainEvent
{
    public IncomingAccountId IncomingAccountId { get; }

    public IncomingAccountDeletedEvent(IncomingAccountId incomingaccountId)
    {
        IncomingAccountId = incomingaccountId;
    }
}
}
