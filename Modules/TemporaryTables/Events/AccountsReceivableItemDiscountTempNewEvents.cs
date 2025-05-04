using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableItemDiscountTempNew entity
/// </summary>
public sealed class AccountsReceivableItemDiscountTempNewCreatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempNewId AccountsReceivableItemDiscountTempNewId { get; }

    public AccountsReceivableItemDiscountTempNewCreatedEvent(AccountsReceivableItemDiscountTempNewId accountsreceivableitemdiscounttempnewId)
    {
        AccountsReceivableItemDiscountTempNewId = accountsreceivableitemdiscounttempnewId;
    }
}

public sealed class AccountsReceivableItemDiscountTempNewUpdatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempNewId AccountsReceivableItemDiscountTempNewId { get; }

    public AccountsReceivableItemDiscountTempNewUpdatedEvent(AccountsReceivableItemDiscountTempNewId accountsreceivableitemdiscounttempnewId)
    {
        AccountsReceivableItemDiscountTempNewId = accountsreceivableitemdiscounttempnewId;
    }
}

public sealed class AccountsReceivableItemDiscountTempNewDeletedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountTempNewId AccountsReceivableItemDiscountTempNewId { get; }

    public AccountsReceivableItemDiscountTempNewDeletedEvent(AccountsReceivableItemDiscountTempNewId accountsreceivableitemdiscounttempnewId)
    {
        AccountsReceivableItemDiscountTempNewId = accountsreceivableitemdiscounttempnewId;
    }
}
}
