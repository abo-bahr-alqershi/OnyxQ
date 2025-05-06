using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to OtherItemAttachment entity
/// </summary>
public sealed class OtherItemAttachmentCreatedEvent : DomainEvent
{
    public OtherItemAttachmentId OtherItemAttachmentId { get; }

    public OtherItemAttachmentCreatedEvent(OtherItemAttachmentId otheritemattachmentId)
    {
        OtherItemAttachmentId = otheritemattachmentId;
    }
}

public sealed class OtherItemAttachmentUpdatedEvent : DomainEvent
{
    public OtherItemAttachmentId OtherItemAttachmentId { get; }

    public OtherItemAttachmentUpdatedEvent(OtherItemAttachmentId otheritemattachmentId)
    {
        OtherItemAttachmentId = otheritemattachmentId;
    }
}

public sealed class OtherItemAttachmentDeletedEvent : DomainEvent
{
    public OtherItemAttachmentId OtherItemAttachmentId { get; }

    public OtherItemAttachmentDeletedEvent(OtherItemAttachmentId otheritemattachmentId)
    {
        OtherItemAttachmentId = otheritemattachmentId;
    }
}
}
