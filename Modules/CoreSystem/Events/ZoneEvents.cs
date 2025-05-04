using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Zone entity
/// </summary>
public sealed class ZoneCreatedEvent : DomainEvent
{
    public ZoneId ZoneId { get; }

    public ZoneCreatedEvent(ZoneId zoneId)
    {
        ZoneId = zoneId;
    }
}

public sealed class ZoneUpdatedEvent : DomainEvent
{
    public ZoneId ZoneId { get; }

    public ZoneUpdatedEvent(ZoneId zoneId)
    {
        ZoneId = zoneId;
    }
}

public sealed class ZoneDeletedEvent : DomainEvent
{
    public ZoneId ZoneId { get; }

    public ZoneDeletedEvent(ZoneId zoneId)
    {
        ZoneId = zoneId;
    }
}
}
