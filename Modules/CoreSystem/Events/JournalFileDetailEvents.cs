using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to JournalFileDetail entity
/// </summary>
public sealed class JournalFileDetailCreatedEvent : DomainEvent
{
    public JournalFileDetailId JournalFileDetailId { get; }

    public JournalFileDetailCreatedEvent(JournalFileDetailId journalfiledetailId)
    {
        JournalFileDetailId = journalfiledetailId;
    }
}

public sealed class JournalFileDetailUpdatedEvent : DomainEvent
{
    public JournalFileDetailId JournalFileDetailId { get; }

    public JournalFileDetailUpdatedEvent(JournalFileDetailId journalfiledetailId)
    {
        JournalFileDetailId = journalfiledetailId;
    }
}

public sealed class JournalFileDetailDeletedEvent : DomainEvent
{
    public JournalFileDetailId JournalFileDetailId { get; }

    public JournalFileDetailDeletedEvent(JournalFileDetailId journalfiledetailId)
    {
        JournalFileDetailId = journalfiledetailId;
    }
}
}
