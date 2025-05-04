using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to Note entity
/// </summary>
public sealed class NoteCreatedEvent : DomainEvent
{
    public NoteId NoteId { get; }

    public NoteCreatedEvent(NoteId noteId)
    {
        NoteId = noteId;
    }
}

public sealed class NoteUpdatedEvent : DomainEvent
{
    public NoteId NoteId { get; }

    public NoteUpdatedEvent(NoteId noteId)
    {
        NoteId = noteId;
    }
}

public sealed class NoteDeletedEvent : DomainEvent
{
    public NoteId NoteId { get; }

    public NoteDeletedEvent(NoteId noteId)
    {
        NoteId = noteId;
    }
}
}
