using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationFuelType entity
/// </summary>
public sealed class StationFuelTypeCreatedEvent : DomainEvent
{
    public StationFuelTypeId StationFuelTypeId { get; }

    public StationFuelTypeCreatedEvent(StationFuelTypeId stationfueltypeId)
    {
        StationFuelTypeId = stationfueltypeId;
    }
}

public sealed class StationFuelTypeUpdatedEvent : DomainEvent
{
    public StationFuelTypeId StationFuelTypeId { get; }

    public StationFuelTypeUpdatedEvent(StationFuelTypeId stationfueltypeId)
    {
        StationFuelTypeId = stationfueltypeId;
    }
}

public sealed class StationFuelTypeDeletedEvent : DomainEvent
{
    public StationFuelTypeId StationFuelTypeId { get; }

    public StationFuelTypeDeletedEvent(StationFuelTypeId stationfueltypeId)
    {
        StationFuelTypeId = stationfueltypeId;
    }
}
}
