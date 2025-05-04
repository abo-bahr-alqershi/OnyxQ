using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JournalVoucherMaster entity
/// </summary>
public sealed class JournalVoucherMasterCreatedEvent : DomainEvent
{
    public JournalVoucherMasterId JournalVoucherMasterId { get; }

    public JournalVoucherMasterCreatedEvent(JournalVoucherMasterId journalvouchermasterId)
    {
        JournalVoucherMasterId = journalvouchermasterId;
    }
}

public sealed class JournalVoucherMasterUpdatedEvent : DomainEvent
{
    public JournalVoucherMasterId JournalVoucherMasterId { get; }

    public JournalVoucherMasterUpdatedEvent(JournalVoucherMasterId journalvouchermasterId)
    {
        JournalVoucherMasterId = journalvouchermasterId;
    }
}

public sealed class JournalVoucherMasterDeletedEvent : DomainEvent
{
    public JournalVoucherMasterId JournalVoucherMasterId { get; }

    public JournalVoucherMasterDeletedEvent(JournalVoucherMasterId journalvouchermasterId)
    {
        JournalVoucherMasterId = journalvouchermasterId;
    }
}
}
