using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to NoteDetail entity
/// </summary>
public sealed class NoteDetailCreatedEvent : DomainEvent
{
    public NoteDetailId NoteDetailId { get; }

    public NoteDetailCreatedEvent(NoteDetailId notedetailId)
    {
        NoteDetailId = notedetailId;
    }
}

public sealed class NoteDetailUpdatedEvent : DomainEvent
{
    public NoteDetailId NoteDetailId { get; }

    public NoteDetailUpdatedEvent(NoteDetailId notedetailId)
    {
        NoteDetailId = notedetailId;
    }
}

public sealed class NoteDetailDeletedEvent : DomainEvent
{
    public NoteDetailId NoteDetailId { get; }

    public NoteDetailDeletedEvent(NoteDetailId notedetailId)
    {
        NoteDetailId = notedetailId;
    }
}
}
