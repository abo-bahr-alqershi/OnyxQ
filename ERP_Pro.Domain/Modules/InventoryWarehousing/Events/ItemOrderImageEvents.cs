using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemOrderImage entity
/// </summary>
public sealed class ItemOrderImageCreatedEvent : DomainEvent
{
    public ItemOrderImageId ItemOrderImageId { get; }

    public ItemOrderImageCreatedEvent(ItemOrderImageId itemorderimageId)
    {
        ItemOrderImageId = itemorderimageId;
    }
}

public sealed class ItemOrderImageUpdatedEvent : DomainEvent
{
    public ItemOrderImageId ItemOrderImageId { get; }

    public ItemOrderImageUpdatedEvent(ItemOrderImageId itemorderimageId)
    {
        ItemOrderImageId = itemorderimageId;
    }
}

public sealed class ItemOrderImageDeletedEvent : DomainEvent
{
    public ItemOrderImageId ItemOrderImageId { get; }

    public ItemOrderImageDeletedEvent(ItemOrderImageId itemorderimageId)
    {
        ItemOrderImageId = itemorderimageId;
    }
}
}
