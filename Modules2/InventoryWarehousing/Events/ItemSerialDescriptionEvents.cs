using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemSerialDescription entity
/// </summary>
public sealed class ItemSerialDescriptionCreatedEvent : DomainEvent
{
    public ItemSerialDescriptionId ItemSerialDescriptionId { get; }

    public ItemSerialDescriptionCreatedEvent(ItemSerialDescriptionId itemserialdescriptionId)
    {
        ItemSerialDescriptionId = itemserialdescriptionId;
    }
}

public sealed class ItemSerialDescriptionUpdatedEvent : DomainEvent
{
    public ItemSerialDescriptionId ItemSerialDescriptionId { get; }

    public ItemSerialDescriptionUpdatedEvent(ItemSerialDescriptionId itemserialdescriptionId)
    {
        ItemSerialDescriptionId = itemserialdescriptionId;
    }
}

public sealed class ItemSerialDescriptionDeletedEvent : DomainEvent
{
    public ItemSerialDescriptionId ItemSerialDescriptionId { get; }

    public ItemSerialDescriptionDeletedEvent(ItemSerialDescriptionId itemserialdescriptionId)
    {
        ItemSerialDescriptionId = itemserialdescriptionId;
    }
}
}
