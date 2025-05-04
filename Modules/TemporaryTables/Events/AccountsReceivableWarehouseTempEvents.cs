using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableWarehouseTemp entity
/// </summary>
public sealed class AccountsReceivableWarehouseTempCreatedEvent : DomainEvent
{
    public AccountsReceivableWarehouseTempId AccountsReceivableWarehouseTempId { get; }

    public AccountsReceivableWarehouseTempCreatedEvent(AccountsReceivableWarehouseTempId accountsreceivablewarehousetempId)
    {
        AccountsReceivableWarehouseTempId = accountsreceivablewarehousetempId;
    }
}

public sealed class AccountsReceivableWarehouseTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableWarehouseTempId AccountsReceivableWarehouseTempId { get; }

    public AccountsReceivableWarehouseTempUpdatedEvent(AccountsReceivableWarehouseTempId accountsreceivablewarehousetempId)
    {
        AccountsReceivableWarehouseTempId = accountsreceivablewarehousetempId;
    }
}

public sealed class AccountsReceivableWarehouseTempDeletedEvent : DomainEvent
{
    public AccountsReceivableWarehouseTempId AccountsReceivableWarehouseTempId { get; }

    public AccountsReceivableWarehouseTempDeletedEvent(AccountsReceivableWarehouseTempId accountsreceivablewarehousetempId)
    {
        AccountsReceivableWarehouseTempId = accountsreceivablewarehousetempId;
    }
}
}
