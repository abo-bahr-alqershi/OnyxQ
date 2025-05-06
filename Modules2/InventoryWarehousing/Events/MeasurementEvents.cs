using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to Measurement entity
/// </summary>
public sealed class MeasurementCreatedEvent : DomainEvent
{
    public MeasurementId MeasurementId { get; }

    public MeasurementCreatedEvent(MeasurementId measurementId)
    {
        MeasurementId = measurementId;
    }
}

public sealed class MeasurementUpdatedEvent : DomainEvent
{
    public MeasurementId MeasurementId { get; }

    public MeasurementUpdatedEvent(MeasurementId measurementId)
    {
        MeasurementId = measurementId;
    }
}

public sealed class MeasurementDeletedEvent : DomainEvent
{
    public MeasurementId MeasurementId { get; }

    public MeasurementDeletedEvent(MeasurementId measurementId)
    {
        MeasurementId = measurementId;
    }
}
}
