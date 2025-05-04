using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemAttachmentMovement entity
/// </summary>
public sealed class ItemAttachmentMovementCreatedEvent : DomainEvent
{
    public ItemAttachmentMovementId ItemAttachmentMovementId { get; }

    public ItemAttachmentMovementCreatedEvent(ItemAttachmentMovementId itemattachmentmovementId)
    {
        ItemAttachmentMovementId = itemattachmentmovementId;
    }
}

public sealed class ItemAttachmentMovementUpdatedEvent : DomainEvent
{
    public ItemAttachmentMovementId ItemAttachmentMovementId { get; }

    public ItemAttachmentMovementUpdatedEvent(ItemAttachmentMovementId itemattachmentmovementId)
    {
        ItemAttachmentMovementId = itemattachmentmovementId;
    }
}

public sealed class ItemAttachmentMovementDeletedEvent : DomainEvent
{
    public ItemAttachmentMovementId ItemAttachmentMovementId { get; }

    public ItemAttachmentMovementDeletedEvent(ItemAttachmentMovementId itemattachmentmovementId)
    {
        ItemAttachmentMovementId = itemattachmentmovementId;
    }
}
}
