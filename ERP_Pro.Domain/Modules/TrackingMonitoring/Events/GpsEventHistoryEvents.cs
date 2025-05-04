using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to GpsEventHistory entity
/// </summary>
public sealed class GpsEventHistoryCreatedEvent : DomainEvent
{
    public GpsEventHistoryId GpsEventHistoryId { get; }

    public GpsEventHistoryCreatedEvent(GpsEventHistoryId gpseventhistoryId)
    {
        GpsEventHistoryId = gpseventhistoryId;
    }
}

public sealed class GpsEventHistoryUpdatedEvent : DomainEvent
{
    public GpsEventHistoryId GpsEventHistoryId { get; }

    public GpsEventHistoryUpdatedEvent(GpsEventHistoryId gpseventhistoryId)
    {
        GpsEventHistoryId = gpseventhistoryId;
    }
}

public sealed class GpsEventHistoryDeletedEvent : DomainEvent
{
    public GpsEventHistoryId GpsEventHistoryId { get; }

    public GpsEventHistoryDeletedEvent(GpsEventHistoryId gpseventhistoryId)
    {
        GpsEventHistoryId = gpseventhistoryId;
    }
}
}
