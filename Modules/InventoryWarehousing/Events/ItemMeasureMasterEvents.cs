using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemMeasureMaster entity
/// </summary>
public sealed class ItemMeasureMasterCreatedEvent : DomainEvent
{
    public ItemMeasureMasterId ItemMeasureMasterId { get; }

    public ItemMeasureMasterCreatedEvent(ItemMeasureMasterId itemmeasuremasterId)
    {
        ItemMeasureMasterId = itemmeasuremasterId;
    }
}

public sealed class ItemMeasureMasterUpdatedEvent : DomainEvent
{
    public ItemMeasureMasterId ItemMeasureMasterId { get; }

    public ItemMeasureMasterUpdatedEvent(ItemMeasureMasterId itemmeasuremasterId)
    {
        ItemMeasureMasterId = itemmeasuremasterId;
    }
}

public sealed class ItemMeasureMasterDeletedEvent : DomainEvent
{
    public ItemMeasureMasterId ItemMeasureMasterId { get; }

    public ItemMeasureMasterDeletedEvent(ItemMeasureMasterId itemmeasuremasterId)
    {
        ItemMeasureMasterId = itemmeasuremasterId;
    }
}
}
