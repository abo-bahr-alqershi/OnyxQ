using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemLevelMeasure entity
/// </summary>
public sealed class ItemLevelMeasureCreatedEvent : DomainEvent
{
    public ItemLevelMeasureId ItemLevelMeasureId { get; }

    public ItemLevelMeasureCreatedEvent(ItemLevelMeasureId itemlevelmeasureId)
    {
        ItemLevelMeasureId = itemlevelmeasureId;
    }
}

public sealed class ItemLevelMeasureUpdatedEvent : DomainEvent
{
    public ItemLevelMeasureId ItemLevelMeasureId { get; }

    public ItemLevelMeasureUpdatedEvent(ItemLevelMeasureId itemlevelmeasureId)
    {
        ItemLevelMeasureId = itemlevelmeasureId;
    }
}

public sealed class ItemLevelMeasureDeletedEvent : DomainEvent
{
    public ItemLevelMeasureId ItemLevelMeasureId { get; }

    public ItemLevelMeasureDeletedEvent(ItemLevelMeasureId itemlevelmeasureId)
    {
        ItemLevelMeasureId = itemlevelmeasureId;
    }
}
}
