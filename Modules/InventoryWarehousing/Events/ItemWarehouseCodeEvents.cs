using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemWarehouseCode entity
/// </summary>
public sealed class ItemWarehouseCodeCreatedEvent : DomainEvent
{
    public ItemWarehouseCodeId ItemWarehouseCodeId { get; }

    public ItemWarehouseCodeCreatedEvent(ItemWarehouseCodeId itemwarehousecodeId)
    {
        ItemWarehouseCodeId = itemwarehousecodeId;
    }
}

public sealed class ItemWarehouseCodeUpdatedEvent : DomainEvent
{
    public ItemWarehouseCodeId ItemWarehouseCodeId { get; }

    public ItemWarehouseCodeUpdatedEvent(ItemWarehouseCodeId itemwarehousecodeId)
    {
        ItemWarehouseCodeId = itemwarehousecodeId;
    }
}

public sealed class ItemWarehouseCodeDeletedEvent : DomainEvent
{
    public ItemWarehouseCodeId ItemWarehouseCodeId { get; }

    public ItemWarehouseCodeDeletedEvent(ItemWarehouseCodeId itemwarehousecodeId)
    {
        ItemWarehouseCodeId = itemwarehousecodeId;
    }
}
}
