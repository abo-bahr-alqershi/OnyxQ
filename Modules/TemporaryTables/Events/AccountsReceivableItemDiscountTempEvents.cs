using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableItemDiscountTemp entity
/// </summary>
public sealed class AccountsReceivableItemDiscountTempCreatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempId AccountsReceivableItemDiscountTempId { get; }

    public AccountsReceivableItemDiscountTempCreatedEvent(AccountsReceivableItemDiscountTempId accountsreceivableitemdiscounttempId)
    {
        AccountsReceivableItemDiscountTempId = accountsreceivableitemdiscounttempId;
    }
}

public sealed class AccountsReceivableItemDiscountTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempId AccountsReceivableItemDiscountTempId { get; }

    public AccountsReceivableItemDiscountTempUpdatedEvent(AccountsReceivableItemDiscountTempId accountsreceivableitemdiscounttempId)
    {
        AccountsReceivableItemDiscountTempId = accountsreceivableitemdiscounttempId;
    }
}

public sealed class AccountsReceivableItemDiscountTempDeletedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempId AccountsReceivableItemDiscountTempId { get; }

    public AccountsReceivableItemDiscountTempDeletedEvent(AccountsReceivableItemDiscountTempId accountsreceivableitemdiscounttempId)
    {
        AccountsReceivableItemDiscountTempId = accountsreceivableitemdiscounttempId;
    }
}
}
