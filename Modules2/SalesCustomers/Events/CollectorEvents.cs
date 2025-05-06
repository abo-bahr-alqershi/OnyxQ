using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to Collector entity
/// </summary>
public sealed class CollectorCreatedEvent : DomainEvent
{
    public CollectorId CollectorId { get; }

    public CollectorCreatedEvent(CollectorId collectorId)
    {
        CollectorId = collectorId;
    }
}

public sealed class CollectorUpdatedEvent : DomainEvent
{
    public CollectorId CollectorId { get; }

    public CollectorUpdatedEvent(CollectorId collectorId)
    {
        CollectorId = collectorId;
    }
}

public sealed class CollectorDeletedEvent : DomainEvent
{
    public CollectorId CollectorId { get; }

    public CollectorDeletedEvent(CollectorId collectorId)
    {
        CollectorId = collectorId;
    }
}
}
