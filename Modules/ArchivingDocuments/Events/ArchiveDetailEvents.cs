using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to ArchiveDetail entity
/// </summary>
public sealed class ArchiveDetailCreatedEvent : DomainEvent
{
    public ArchiveDetailId ArchiveDetailId { get; }

    public ArchiveDetailCreatedEvent(ArchiveDetailId archivedetailId)
    {
        ArchiveDetailId = archivedetailId;
    }
}

public sealed class ArchiveDetailUpdatedEvent : DomainEvent
{
    public ArchiveDetailId ArchiveDetailId { get; }

    public ArchiveDetailUpdatedEvent(ArchiveDetailId archivedetailId)
    {
        ArchiveDetailId = archivedetailId;
    }
}

public sealed class ArchiveDetailDeletedEvent : DomainEvent
{
    public ArchiveDetailId ArchiveDetailId { get; }

    public ArchiveDetailDeletedEvent(ArchiveDetailId archivedetailId)
    {
        ArchiveDetailId = archivedetailId;
    }
}
}
