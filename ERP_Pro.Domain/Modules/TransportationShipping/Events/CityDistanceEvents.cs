using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to CityDistance entity
/// </summary>
public sealed class CityDistanceCreatedEvent : DomainEvent
{
    public CityDistanceId CityDistanceId { get; }

    public CityDistanceCreatedEvent(CityDistanceId citydistanceId)
    {
        CityDistanceId = citydistanceId;
    }
}

public sealed class CityDistanceUpdatedEvent : DomainEvent
{
    public CityDistanceId CityDistanceId { get; }

    public CityDistanceUpdatedEvent(CityDistanceId citydistanceId)
    {
        CityDistanceId = citydistanceId;
    }
}

public sealed class CityDistanceDeletedEvent : DomainEvent
{
    public CityDistanceId CityDistanceId { get; }

    public CityDistanceDeletedEvent(CityDistanceId citydistanceId)
    {
        CityDistanceId = citydistanceId;
    }
}
}
