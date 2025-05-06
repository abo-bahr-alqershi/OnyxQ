using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AutoSalesOrderMaster entity
/// </summary>
public sealed class AutoSalesOrderMasterCreatedEvent : DomainEvent
{
    public AutoSalesOrderMasterId AutoSalesOrderMasterId { get; }

    public AutoSalesOrderMasterCreatedEvent(AutoSalesOrderMasterId autosalesordermasterId)
    {
        AutoSalesOrderMasterId = autosalesordermasterId;
    }
}

public sealed class AutoSalesOrderMasterUpdatedEvent : DomainEvent
{
    public AutoSalesOrderMasterId AutoSalesOrderMasterId { get; }

    public AutoSalesOrderMasterUpdatedEvent(AutoSalesOrderMasterId autosalesordermasterId)
    {
        AutoSalesOrderMasterId = autosalesordermasterId;
    }
}

public sealed class AutoSalesOrderMasterDeletedEvent : DomainEvent
{
    public AutoSalesOrderMasterId AutoSalesOrderMasterId { get; }

    public AutoSalesOrderMasterDeletedEvent(AutoSalesOrderMasterId autosalesordermasterId)
    {
        AutoSalesOrderMasterId = autosalesordermasterId;
    }
}
}
