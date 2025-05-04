using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to AttachmentDetail entity
/// </summary>
public sealed class AttachmentDetailCreatedEvent : DomainEvent
{
    public AttachmentDetailId AttachmentDetailId { get; }

    public AttachmentDetailCreatedEvent(AttachmentDetailId attachmentdetailId)
    {
        AttachmentDetailId = attachmentdetailId;
    }
}

public sealed class AttachmentDetailUpdatedEvent : DomainEvent
{
    public AttachmentDetailId AttachmentDetailId { get; }

    public AttachmentDetailUpdatedEvent(AttachmentDetailId attachmentdetailId)
    {
        AttachmentDetailId = attachmentdetailId;
    }
}

public sealed class AttachmentDetailDeletedEvent : DomainEvent
{
    public AttachmentDetailId AttachmentDetailId { get; }

    public AttachmentDetailDeletedEvent(AttachmentDetailId attachmentdetailId)
    {
        AttachmentDetailId = attachmentdetailId;
    }
}
}
