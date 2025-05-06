using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to DriverIdentification entity
/// </summary>
public sealed class DriverIdentificationCreatedEvent : DomainEvent
{
    public DriverIdentificationId DriverIdentificationId { get; }

    public DriverIdentificationCreatedEvent(DriverIdentificationId driveridentificationId)
    {
        DriverIdentificationId = driveridentificationId;
    }
}

public sealed class DriverIdentificationUpdatedEvent : DomainEvent
{
    public DriverIdentificationId DriverIdentificationId { get; }

    public DriverIdentificationUpdatedEvent(DriverIdentificationId driveridentificationId)
    {
        DriverIdentificationId = driveridentificationId;
    }
}

public sealed class DriverIdentificationDeletedEvent : DomainEvent
{
    public DriverIdentificationId DriverIdentificationId { get; }

    public DriverIdentificationDeletedEvent(DriverIdentificationId driveridentificationId)
    {
        DriverIdentificationId = driveridentificationId;
    }
}
}
