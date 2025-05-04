using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountCurrency entity
/// </summary>
public sealed class AccountCurrencyCreatedEvent : DomainEvent
{
    public AccountCurrencyId AccountCurrencyId { get; }

    public AccountCurrencyCreatedEvent(AccountCurrencyId accountcurrencyId)
    {
        AccountCurrencyId = accountcurrencyId;
    }
}

public sealed class AccountCurrencyUpdatedEvent : DomainEvent
{
    public AccountCurrencyId AccountCurrencyId { get; }

    public AccountCurrencyUpdatedEvent(AccountCurrencyId accountcurrencyId)
    {
        AccountCurrencyId = accountcurrencyId;
    }
}

public sealed class AccountCurrencyDeletedEvent : DomainEvent
{
    public AccountCurrencyId AccountCurrencyId { get; }

    public AccountCurrencyDeletedEvent(AccountCurrencyId accountcurrencyId)
    {
        AccountCurrencyId = accountcurrencyId;
    }
}
}
