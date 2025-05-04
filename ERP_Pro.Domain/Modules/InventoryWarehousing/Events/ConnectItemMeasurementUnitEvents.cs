using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ConnectItemMeasurementUnit entity
/// </summary>
public sealed class ConnectItemMeasurementUnitCreatedEvent : DomainEvent
{
    public ConnectItemMeasurementUnitId ConnectItemMeasurementUnitId { get; }

    public ConnectItemMeasurementUnitCreatedEvent(ConnectItemMeasurementUnitId connectitemmeasurementunitId)
    {
        ConnectItemMeasurementUnitId = connectitemmeasurementunitId;
    }
}

public sealed class ConnectItemMeasurementUnitUpdatedEvent : DomainEvent
{
    public ConnectItemMeasurementUnitId ConnectItemMeasurementUnitId { get; }

    public ConnectItemMeasurementUnitUpdatedEvent(ConnectItemMeasurementUnitId connectitemmeasurementunitId)
    {
        ConnectItemMeasurementUnitId = connectitemmeasurementunitId;
    }
}

public sealed class ConnectItemMeasurementUnitDeletedEvent : DomainEvent
{
    public ConnectItemMeasurementUnitId ConnectItemMeasurementUnitId { get; }

    public ConnectItemMeasurementUnitDeletedEvent(ConnectItemMeasurementUnitId connectitemmeasurementunitId)
    {
        ConnectItemMeasurementUnitId = connectitemmeasurementunitId;
    }
}
}
