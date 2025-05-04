using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to Driver entity
/// </summary>
public sealed class DriverCreatedEvent : DomainEvent
{
    public DriverId DriverId { get; }

    public DriverCreatedEvent(DriverId driverId)
    {
        DriverId = driverId;
    }
}

public sealed class DriverUpdatedEvent : DomainEvent
{
    public DriverId DriverId { get; }

    public DriverUpdatedEvent(DriverId driverId)
    {
        DriverId = driverId;
    }
}

public sealed class DriverDeletedEvent : DomainEvent
{
    public DriverId DriverId { get; }

    public DriverDeletedEvent(DriverId driverId)
    {
        DriverId = driverId;
    }
}
}
