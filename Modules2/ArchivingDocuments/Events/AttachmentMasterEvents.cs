using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to AttachmentMaster entity
/// </summary>
public sealed class AttachmentMasterCreatedEvent : DomainEvent
{
    public AttachmentMasterId AttachmentMasterId { get; }

    public AttachmentMasterCreatedEvent(AttachmentMasterId attachmentmasterId)
    {
        AttachmentMasterId = attachmentmasterId;
    }
}

public sealed class AttachmentMasterUpdatedEvent : DomainEvent
{
    public AttachmentMasterId AttachmentMasterId { get; }

    public AttachmentMasterUpdatedEvent(AttachmentMasterId attachmentmasterId)
    {
        AttachmentMasterId = attachmentmasterId;
    }
}

public sealed class AttachmentMasterDeletedEvent : DomainEvent
{
    public AttachmentMasterId AttachmentMasterId { get; }

    public AttachmentMasterDeletedEvent(AttachmentMasterId attachmentmasterId)
    {
        AttachmentMasterId = attachmentmasterId;
    }
}
}
