using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JournalVoucherDetail entity
/// </summary>
public sealed class JournalVoucherDetailCreatedEvent : DomainEvent
{
    public JournalVoucherDetailId JournalVoucherDetailId { get; }

    public JournalVoucherDetailCreatedEvent(JournalVoucherDetailId journalvoucherdetailId)
    {
        JournalVoucherDetailId = journalvoucherdetailId;
    }
}

public sealed class JournalVoucherDetailUpdatedEvent : DomainEvent
{
    public JournalVoucherDetailId JournalVoucherDetailId { get; }

    public JournalVoucherDetailUpdatedEvent(JournalVoucherDetailId journalvoucherdetailId)
    {
        JournalVoucherDetailId = journalvoucherdetailId;
    }
}

public sealed class JournalVoucherDetailDeletedEvent : DomainEvent
{
    public JournalVoucherDetailId JournalVoucherDetailId { get; }

    public JournalVoucherDetailDeletedEvent(JournalVoucherDetailId journalvoucherdetailId)
    {
        JournalVoucherDetailId = journalvoucherdetailId;
    }
}
}
