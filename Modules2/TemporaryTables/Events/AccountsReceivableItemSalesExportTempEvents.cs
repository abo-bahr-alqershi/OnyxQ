using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableItemSalesExportTemp entity
/// </summary>
public sealed class AccountsReceivableItemSalesExportTempCreatedEvent : DomainEvent
{
    public AccountsReceivableItemSalesExportTempId AccountsReceivableItemSalesExportTempId { get; }

    public AccountsReceivableItemSalesExportTempCreatedEvent(AccountsReceivableItemSalesExportTempId accountsreceivableitemsalesexporttempId)
    {
        AccountsReceivableItemSalesExportTempId = accountsreceivableitemsalesexporttempId;
    }
}

public sealed class AccountsReceivableItemSalesExportTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableItemSalesExportTempId AccountsReceivableItemSalesExportTempId { get; }

    public AccountsReceivableItemSalesExportTempUpdatedEvent(AccountsReceivableItemSalesExportTempId accountsreceivableitemsalesexporttempId)
    {
        AccountsReceivableItemSalesExportTempId = accountsreceivableitemsalesexporttempId;
    }
}

public sealed class AccountsReceivableItemSalesExportTempDeletedEvent : DomainEvent
{
    public AccountsReceivableItemSalesExportTempId AccountsReceivableItemSalesExportTempId { get; }

    public AccountsReceivableItemSalesExportTempDeletedEvent(AccountsReceivableItemSalesExportTempId accountsreceivableitemsalesexporttempId)
    {
        AccountsReceivableItemSalesExportTempId = accountsreceivableitemsalesexporttempId;
    }
}
}
