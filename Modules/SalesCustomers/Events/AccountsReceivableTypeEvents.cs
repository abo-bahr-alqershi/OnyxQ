using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AccountsReceivableType entity
/// </summary>
public sealed class AccountsReceivableTypeCreatedEvent : DomainEvent
{
    public AccountsReceivableTypeId AccountsReceivableTypeId { get; }

    public AccountsReceivableTypeCreatedEvent(AccountsReceivableTypeId accountsreceivabletypeId)
    {
        AccountsReceivableTypeId = accountsreceivabletypeId;
    }
}

public sealed class AccountsReceivableTypeUpdatedEvent : DomainEvent
{
    public AccountsReceivableTypeId AccountsReceivableTypeId { get; }

    public AccountsReceivableTypeUpdatedEvent(AccountsReceivableTypeId accountsreceivabletypeId)
    {
        AccountsReceivableTypeId = accountsreceivabletypeId;
    }
}

public sealed class AccountsReceivableTypeDeletedEvent : DomainEvent
{
    public AccountsReceivableTypeId AccountsReceivableTypeId { get; }

    public AccountsReceivableTypeDeletedEvent(AccountsReceivableTypeId accountsreceivabletypeId)
    {
        AccountsReceivableTypeId = accountsreceivabletypeId;
    }
}
}
