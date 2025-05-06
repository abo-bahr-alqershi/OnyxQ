using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemBatch entity
/// </summary>
public sealed class ItemBatchCreatedEvent : DomainEvent
{
    public ItemBatchId ItemBatchId { get; }

    public ItemBatchCreatedEvent(ItemBatchId itembatchId)
    {
        ItemBatchId = itembatchId;
    }
}

public sealed class ItemBatchUpdatedEvent : DomainEvent
{
    public ItemBatchId ItemBatchId { get; }

    public ItemBatchUpdatedEvent(ItemBatchId itembatchId)
    {
        ItemBatchId = itembatchId;
    }
}

public sealed class ItemBatchDeletedEvent : DomainEvent
{
    public ItemBatchId ItemBatchId { get; }

    public ItemBatchDeletedEvent(ItemBatchId itembatchId)
    {
        ItemBatchId = itembatchId;
    }
}
}
