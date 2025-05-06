using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemOnlineImage entity
/// </summary>
public sealed class ItemOnlineImageCreatedEvent : DomainEvent
{
    public ItemOnlineImageId ItemOnlineImageId { get; }

    public ItemOnlineImageCreatedEvent(ItemOnlineImageId itemonlineimageId)
    {
        ItemOnlineImageId = itemonlineimageId;
    }
}

public sealed class ItemOnlineImageUpdatedEvent : DomainEvent
{
    public ItemOnlineImageId ItemOnlineImageId { get; }

    public ItemOnlineImageUpdatedEvent(ItemOnlineImageId itemonlineimageId)
    {
        ItemOnlineImageId = itemonlineimageId;
    }
}

public sealed class ItemOnlineImageDeletedEvent : DomainEvent
{
    public ItemOnlineImageId ItemOnlineImageId { get; }

    public ItemOnlineImageDeletedEvent(ItemOnlineImageId itemonlineimageId)
    {
        ItemOnlineImageId = itemonlineimageId;
    }
}
}
