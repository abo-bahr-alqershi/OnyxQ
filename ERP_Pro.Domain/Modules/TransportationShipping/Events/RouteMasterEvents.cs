using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to RouteMaster entity
/// </summary>
public sealed class RouteMasterCreatedEvent : DomainEvent
{
    public RouteMasterId RouteMasterId { get; }

    public RouteMasterCreatedEvent(RouteMasterId routemasterId)
    {
        RouteMasterId = routemasterId;
    }
}

public sealed class RouteMasterUpdatedEvent : DomainEvent
{
    public RouteMasterId RouteMasterId { get; }

    public RouteMasterUpdatedEvent(RouteMasterId routemasterId)
    {
        RouteMasterId = routemasterId;
    }
}

public sealed class RouteMasterDeletedEvent : DomainEvent
{
    public RouteMasterId RouteMasterId { get; }

    public RouteMasterDeletedEvent(RouteMasterId routemasterId)
    {
        RouteMasterId = routemasterId;
    }
}
}
