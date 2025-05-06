using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableItemDiscountAgeTemp entity
/// </summary>
public sealed class AccountsReceivableItemDiscountAgeTempCreatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountAgeTempId AccountsReceivableItemDiscountAgeTempId { get; }

    public AccountsReceivableItemDiscountAgeTempCreatedEvent(AccountsReceivableItemDiscountAgeTempId accountsreceivableitemdiscountagetempId)
    {
        AccountsReceivableItemDiscountAgeTempId = accountsreceivableitemdiscountagetempId;
    }
}

public sealed class AccountsReceivableItemDiscountAgeTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountAgeTempId AccountsReceivableItemDiscountAgeTempId { get; }

    public AccountsReceivableItemDiscountAgeTempUpdatedEvent(AccountsReceivableItemDiscountAgeTempId accountsreceivableitemdiscountagetempId)
    {
        AccountsReceivableItemDiscountAgeTempId = accountsreceivableitemdiscountagetempId;
    }
}

public sealed class AccountsReceivableItemDiscountAgeTempDeletedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountAgeTempId AccountsReceivableItemDiscountAgeTempId { get; }

    public AccountsReceivableItemDiscountAgeTempDeletedEvent(AccountsReceivableItemDiscountAgeTempId accountsreceivableitemdiscountagetempId)
    {
        AccountsReceivableItemDiscountAgeTempId = accountsreceivableitemdiscountagetempId;
    }
}
}
