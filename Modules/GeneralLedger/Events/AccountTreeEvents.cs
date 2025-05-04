using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountTree entity
/// </summary>
public sealed class AccountTreeCreatedEvent : DomainEvent
{
    public AccountTreeId AccountTreeId { get; }

    public AccountTreeCreatedEvent(AccountTreeId accounttreeId)
    {
        AccountTreeId = accounttreeId;
    }
}

public sealed class AccountTreeUpdatedEvent : DomainEvent
{
    public AccountTreeId AccountTreeId { get; }

    public AccountTreeUpdatedEvent(AccountTreeId accounttreeId)
    {
        AccountTreeId = accounttreeId;
    }
}

public sealed class AccountTreeDeletedEvent : DomainEvent
{
    public AccountTreeId AccountTreeId { get; }

    public AccountTreeDeletedEvent(AccountTreeId accounttreeId)
    {
        AccountTreeId = accounttreeId;
    }
}
}
