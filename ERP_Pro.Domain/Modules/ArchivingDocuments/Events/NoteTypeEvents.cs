using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to NoteType entity
/// </summary>
public sealed class NoteTypeCreatedEvent : DomainEvent
{
    public NoteTypeId NoteTypeId { get; }

    public NoteTypeCreatedEvent(NoteTypeId notetypeId)
    {
        NoteTypeId = notetypeId;
    }
}

public sealed class NoteTypeUpdatedEvent : DomainEvent
{
    public NoteTypeId NoteTypeId { get; }

    public NoteTypeUpdatedEvent(NoteTypeId notetypeId)
    {
        NoteTypeId = notetypeId;
    }
}

public sealed class NoteTypeDeletedEvent : DomainEvent
{
    public NoteTypeId NoteTypeId { get; }

    public NoteTypeDeletedEvent(NoteTypeId notetypeId)
    {
        NoteTypeId = notetypeId;
    }
}
}
