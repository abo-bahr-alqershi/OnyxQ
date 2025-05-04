using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemSerialNumber entity
/// </summary>
public sealed class ItemSerialNumberCreatedEvent : DomainEvent
{
    public ItemSerialNumberId ItemSerialNumberId { get; }

    public ItemSerialNumberCreatedEvent(ItemSerialNumberId itemserialnumberId)
    {
        ItemSerialNumberId = itemserialnumberId;
    }
}

public sealed class ItemSerialNumberUpdatedEvent : DomainEvent
{
    public ItemSerialNumberId ItemSerialNumberId { get; }

    public ItemSerialNumberUpdatedEvent(ItemSerialNumberId itemserialnumberId)
    {
        ItemSerialNumberId = itemserialnumberId;
    }
}

public sealed class ItemSerialNumberDeletedEvent : DomainEvent
{
    public ItemSerialNumberId ItemSerialNumberId { get; }

    public ItemSerialNumberDeletedEvent(ItemSerialNumberId itemserialnumberId)
    {
        ItemSerialNumberId = itemserialnumberId;
    }
}
}
