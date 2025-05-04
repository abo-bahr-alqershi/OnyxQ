using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesOrderType entity
/// </summary>
public sealed class SalesOrderTypeCreatedEvent : DomainEvent
{
    public SalesOrderTypeId SalesOrderTypeId { get; }

    public SalesOrderTypeCreatedEvent(SalesOrderTypeId salesordertypeId)
    {
        SalesOrderTypeId = salesordertypeId;
    }
}

public sealed class SalesOrderTypeUpdatedEvent : DomainEvent
{
    public SalesOrderTypeId SalesOrderTypeId { get; }

    public SalesOrderTypeUpdatedEvent(SalesOrderTypeId salesordertypeId)
    {
        SalesOrderTypeId = salesordertypeId;
    }
}

public sealed class SalesOrderTypeDeletedEvent : DomainEvent
{
    public SalesOrderTypeId SalesOrderTypeId { get; }

    public SalesOrderTypeDeletedEvent(SalesOrderTypeId salesordertypeId)
    {
        SalesOrderTypeId = salesordertypeId;
    }
}
}
