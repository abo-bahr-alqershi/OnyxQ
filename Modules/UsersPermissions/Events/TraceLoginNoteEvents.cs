using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to TraceLoginNote entity
/// </summary>
public sealed class TraceLoginNoteCreatedEvent : DomainEvent
{
    public TraceLoginNoteId TraceLoginNoteId { get; }

    public TraceLoginNoteCreatedEvent(TraceLoginNoteId traceloginnoteId)
    {
        TraceLoginNoteId = traceloginnoteId;
    }
}

public sealed class TraceLoginNoteUpdatedEvent : DomainEvent
{
    public TraceLoginNoteId TraceLoginNoteId { get; }

    public TraceLoginNoteUpdatedEvent(TraceLoginNoteId traceloginnoteId)
    {
        TraceLoginNoteId = traceloginnoteId;
    }
}

public sealed class TraceLoginNoteDeletedEvent : DomainEvent
{
    public TraceLoginNoteId TraceLoginNoteId { get; }

    public TraceLoginNoteDeletedEvent(TraceLoginNoteId traceloginnoteId)
    {
        TraceLoginNoteId = traceloginnoteId;
    }
}
}
