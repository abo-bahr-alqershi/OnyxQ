using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemMeasureDetail entity
/// </summary>
public sealed class ItemMeasureDetailCreatedEvent : DomainEvent
{
    public ItemMeasureDetailId ItemMeasureDetailId { get; }

    public ItemMeasureDetailCreatedEvent(ItemMeasureDetailId itemmeasuredetailId)
    {
        ItemMeasureDetailId = itemmeasuredetailId;
    }
}

public sealed class ItemMeasureDetailUpdatedEvent : DomainEvent
{
    public ItemMeasureDetailId ItemMeasureDetailId { get; }

    public ItemMeasureDetailUpdatedEvent(ItemMeasureDetailId itemmeasuredetailId)
    {
        ItemMeasureDetailId = itemmeasuredetailId;
    }
}

public sealed class ItemMeasureDetailDeletedEvent : DomainEvent
{
    public ItemMeasureDetailId ItemMeasureDetailId { get; }

    public ItemMeasureDetailDeletedEvent(ItemMeasureDetailId itemmeasuredetailId)
    {
        ItemMeasureDetailId = itemmeasuredetailId;
    }
}
}
