using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to ArchiveMaster entity
/// </summary>
public sealed class ArchiveMasterCreatedEvent : DomainEvent
{
    public ArchiveMasterId ArchiveMasterId { get; }

    public ArchiveMasterCreatedEvent(ArchiveMasterId archivemasterId)
    {
        ArchiveMasterId = archivemasterId;
    }
}

public sealed class ArchiveMasterUpdatedEvent : DomainEvent
{
    public ArchiveMasterId ArchiveMasterId { get; }

    public ArchiveMasterUpdatedEvent(ArchiveMasterId archivemasterId)
    {
        ArchiveMasterId = archivemasterId;
    }
}

public sealed class ArchiveMasterDeletedEvent : DomainEvent
{
    public ArchiveMasterId ArchiveMasterId { get; }

    public ArchiveMasterDeletedEvent(ArchiveMasterId archivemasterId)
    {
        ArchiveMasterId = archivemasterId;
    }
}
}
