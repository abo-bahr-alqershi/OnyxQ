using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to JournalFileMaster entity
/// </summary>
public sealed class JournalFileMasterCreatedEvent : DomainEvent
{
    public JournalFileMasterId JournalFileMasterId { get; }

    public JournalFileMasterCreatedEvent(JournalFileMasterId journalfilemasterId)
    {
        JournalFileMasterId = journalfilemasterId;
    }
}

public sealed class JournalFileMasterUpdatedEvent : DomainEvent
{
    public JournalFileMasterId JournalFileMasterId { get; }

    public JournalFileMasterUpdatedEvent(JournalFileMasterId journalfilemasterId)
    {
        JournalFileMasterId = journalfilemasterId;
    }
}

public sealed class JournalFileMasterDeletedEvent : DomainEvent
{
    public JournalFileMasterId JournalFileMasterId { get; }

    public JournalFileMasterDeletedEvent(JournalFileMasterId journalfilemasterId)
    {
        JournalFileMasterId = journalfilemasterId;
    }
}
}
