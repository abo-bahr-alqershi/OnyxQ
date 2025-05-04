using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to Account entity
/// </summary>
public sealed class AccountCreatedEvent : DomainEvent
{
    public AccountId AccountId { get; }

    public AccountCreatedEvent(AccountId accountId)
    {
        AccountId = accountId;
    }
}

public sealed class AccountUpdatedEvent : DomainEvent
{
    public AccountId AccountId { get; }

    public AccountUpdatedEvent(AccountId accountId)
    {
        AccountId = accountId;
    }
}

public sealed class AccountDeletedEvent : DomainEvent
{
    public AccountId AccountId { get; }

    public AccountDeletedEvent(AccountId accountId)
    {
        AccountId = accountId;
    }
}
}
