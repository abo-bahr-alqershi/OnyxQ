using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesOrder entity
/// </summary>
public sealed class SalesOrderCreatedEvent : DomainEvent
{
    public SalesOrderId SalesOrderId { get; }

    public SalesOrderCreatedEvent(SalesOrderId salesorderId)
    {
        SalesOrderId = salesorderId;
    }
}

public sealed class SalesOrderUpdatedEvent : DomainEvent
{
    public SalesOrderId SalesOrderId { get; }

    public SalesOrderUpdatedEvent(SalesOrderId salesorderId)
    {
        SalesOrderId = salesorderId;
    }
}

public sealed class SalesOrderDeletedEvent : DomainEvent
{
    public SalesOrderId SalesOrderId { get; }

    public SalesOrderDeletedEvent(SalesOrderId salesorderId)
    {
        SalesOrderId = salesorderId;
    }
}
}
