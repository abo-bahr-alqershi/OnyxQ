using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to GpsEvent entity
/// </summary>
public sealed class GpsEventCreatedEvent : DomainEvent
{
    public GpsEventId GpsEventId { get; }

    public GpsEventCreatedEvent(GpsEventId gpseventId)
    {
        GpsEventId = gpseventId;
    }
}

public sealed class GpsEventUpdatedEvent : DomainEvent
{
    public GpsEventId GpsEventId { get; }

    public GpsEventUpdatedEvent(GpsEventId gpseventId)
    {
        GpsEventId = gpseventId;
    }
}

public sealed class GpsEventDeletedEvent : DomainEvent
{
    public GpsEventId GpsEventId { get; }

    public GpsEventDeletedEvent(GpsEventId gpseventId)
    {
        GpsEventId = gpseventId;
    }
}
}
