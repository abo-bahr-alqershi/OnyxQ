using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to RouteDetail entity
/// </summary>
public sealed class RouteDetailCreatedEvent : DomainEvent
{
    public RouteDetailId RouteDetailId { get; }

    public RouteDetailCreatedEvent(RouteDetailId routedetailId)
    {
        RouteDetailId = routedetailId;
    }
}

public sealed class RouteDetailUpdatedEvent : DomainEvent
{
    public RouteDetailId RouteDetailId { get; }

    public RouteDetailUpdatedEvent(RouteDetailId routedetailId)
    {
        RouteDetailId = routedetailId;
    }
}

public sealed class RouteDetailDeletedEvent : DomainEvent
{
    public RouteDetailId RouteDetailId { get; }

    public RouteDetailDeletedEvent(RouteDetailId routedetailId)
    {
        RouteDetailId = routedetailId;
    }
}
}
