using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JournalVoucherTypeDetail entity
/// </summary>
public sealed class JournalVoucherTypeDetailCreatedEvent : DomainEvent
{
    public JournalVoucherTypeDetailId JournalVoucherTypeDetailId { get; }

    public JournalVoucherTypeDetailCreatedEvent(JournalVoucherTypeDetailId journalvouchertypedetailId)
    {
        JournalVoucherTypeDetailId = journalvouchertypedetailId;
    }
}

public sealed class JournalVoucherTypeDetailUpdatedEvent : DomainEvent
{
    public JournalVoucherTypeDetailId JournalVoucherTypeDetailId { get; }

    public JournalVoucherTypeDetailUpdatedEvent(JournalVoucherTypeDetailId journalvouchertypedetailId)
    {
        JournalVoucherTypeDetailId = journalvouchertypedetailId;
    }
}

public sealed class JournalVoucherTypeDetailDeletedEvent : DomainEvent
{
    public JournalVoucherTypeDetailId JournalVoucherTypeDetailId { get; }

    public JournalVoucherTypeDetailDeletedEvent(JournalVoucherTypeDetailId journalvouchertypedetailId)
    {
        JournalVoucherTypeDetailId = journalvouchertypedetailId;
    }
}
}
