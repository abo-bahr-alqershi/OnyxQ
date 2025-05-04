using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCounter entity
/// </summary>
public sealed class StationCounterCreatedEvent : DomainEvent
{
    public StationCounterId StationCounterId { get; }

    public StationCounterCreatedEvent(StationCounterId stationcounterId)
    {
        StationCounterId = stationcounterId;
    }
}

public sealed class StationCounterUpdatedEvent : DomainEvent
{
    public StationCounterId StationCounterId { get; }

    public StationCounterUpdatedEvent(StationCounterId stationcounterId)
    {
        StationCounterId = stationcounterId;
    }
}

public sealed class StationCounterDeletedEvent : DomainEvent
{
    public StationCounterId StationCounterId { get; }

    public StationCounterDeletedEvent(StationCounterId stationcounterId)
    {
        StationCounterId = stationcounterId;
    }
}
}
