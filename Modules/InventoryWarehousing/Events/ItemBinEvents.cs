using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemBin entity
/// </summary>
public sealed class ItemBinCreatedEvent : DomainEvent
{
    public ItemBinId ItemBinId { get; }

    public ItemBinCreatedEvent(ItemBinId itembinId)
    {
        ItemBinId = itembinId;
    }
}

public sealed class ItemBinUpdatedEvent : DomainEvent
{
    public ItemBinId ItemBinId { get; }

    public ItemBinUpdatedEvent(ItemBinId itembinId)
    {
        ItemBinId = itembinId;
    }
}

public sealed class ItemBinDeletedEvent : DomainEvent
{
    public ItemBinId ItemBinId { get; }

    public ItemBinDeletedEvent(ItemBinId itembinId)
    {
        ItemBinId = itembinId;
    }
}
}
