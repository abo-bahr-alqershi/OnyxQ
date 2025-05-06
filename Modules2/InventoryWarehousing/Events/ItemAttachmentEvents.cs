using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemAttachment entity
/// </summary>
public sealed class ItemAttachmentCreatedEvent : DomainEvent
{
    public ItemAttachmentId ItemAttachmentId { get; }

    public ItemAttachmentCreatedEvent(ItemAttachmentId itemattachmentId)
    {
        ItemAttachmentId = itemattachmentId;
    }
}

public sealed class ItemAttachmentUpdatedEvent : DomainEvent
{
    public ItemAttachmentId ItemAttachmentId { get; }

    public ItemAttachmentUpdatedEvent(ItemAttachmentId itemattachmentId)
    {
        ItemAttachmentId = itemattachmentId;
    }
}

public sealed class ItemAttachmentDeletedEvent : DomainEvent
{
    public ItemAttachmentId ItemAttachmentId { get; }

    public ItemAttachmentDeletedEvent(ItemAttachmentId itemattachmentId)
    {
        ItemAttachmentId = itemattachmentId;
    }
}
}
