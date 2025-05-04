using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to AutoSalesOrderDetail entity
/// </summary>
public sealed class AutoSalesOrderDetailCreatedEvent : DomainEvent
{
    public AutoSalesOrderDetailId AutoSalesOrderDetailId { get; }

    public AutoSalesOrderDetailCreatedEvent(AutoSalesOrderDetailId autosalesorderdetailId)
    {
        AutoSalesOrderDetailId = autosalesorderdetailId;
    }
}

public sealed class AutoSalesOrderDetailUpdatedEvent : DomainEvent
{
    public AutoSalesOrderDetailId AutoSalesOrderDetailId { get; }

    public AutoSalesOrderDetailUpdatedEvent(AutoSalesOrderDetailId autosalesorderdetailId)
    {
        AutoSalesOrderDetailId = autosalesorderdetailId;
    }
}

public sealed class AutoSalesOrderDetailDeletedEvent : DomainEvent
{
    public AutoSalesOrderDetailId AutoSalesOrderDetailId { get; }

    public AutoSalesOrderDetailDeletedEvent(AutoSalesOrderDetailId autosalesorderdetailId)
    {
        AutoSalesOrderDetailId = autosalesorderdetailId;
    }
}
}
