using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemLevel entity
/// </summary>
public sealed class ItemLevelCreatedEvent : DomainEvent
{
    public ItemLevelId ItemLevelId { get; }

    public ItemLevelCreatedEvent(ItemLevelId itemlevelId)
    {
        ItemLevelId = itemlevelId;
    }
}

public sealed class ItemLevelUpdatedEvent : DomainEvent
{
    public ItemLevelId ItemLevelId { get; }

    public ItemLevelUpdatedEvent(ItemLevelId itemlevelId)
    {
        ItemLevelId = itemlevelId;
    }
}

public sealed class ItemLevelDeletedEvent : DomainEvent
{
    public ItemLevelId ItemLevelId { get; }

    public ItemLevelDeletedEvent(ItemLevelId itemlevelId)
    {
        ItemLevelId = itemlevelId;
    }
}
}
