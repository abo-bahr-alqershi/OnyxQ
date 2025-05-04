using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemLevelMeasureDetail entity
/// </summary>
public sealed class ItemLevelMeasureDetailCreatedEvent : DomainEvent
{
    public ItemLevelMeasureDetailId ItemLevelMeasureDetailId { get; }

    public ItemLevelMeasureDetailCreatedEvent(ItemLevelMeasureDetailId itemlevelmeasuredetailId)
    {
        ItemLevelMeasureDetailId = itemlevelmeasuredetailId;
    }
}

public sealed class ItemLevelMeasureDetailUpdatedEvent : DomainEvent
{
    public ItemLevelMeasureDetailId ItemLevelMeasureDetailId { get; }

    public ItemLevelMeasureDetailUpdatedEvent(ItemLevelMeasureDetailId itemlevelmeasuredetailId)
    {
        ItemLevelMeasureDetailId = itemlevelmeasuredetailId;
    }
}

public sealed class ItemLevelMeasureDetailDeletedEvent : DomainEvent
{
    public ItemLevelMeasureDetailId ItemLevelMeasureDetailId { get; }

    public ItemLevelMeasureDetailDeletedEvent(ItemLevelMeasureDetailId itemlevelmeasuredetailId)
    {
        ItemLevelMeasureDetailId = itemlevelmeasuredetailId;
    }
}
}
