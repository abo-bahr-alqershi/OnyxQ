using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JournalVoucherType entity
/// </summary>
public sealed class JournalVoucherTypeCreatedEvent : DomainEvent
{
    public JournalVoucherTypeId JournalVoucherTypeId { get; }

    public JournalVoucherTypeCreatedEvent(JournalVoucherTypeId journalvouchertypeId)
    {
        JournalVoucherTypeId = journalvouchertypeId;
    }
}

public sealed class JournalVoucherTypeUpdatedEvent : DomainEvent
{
    public JournalVoucherTypeId JournalVoucherTypeId { get; }

    public JournalVoucherTypeUpdatedEvent(JournalVoucherTypeId journalvouchertypeId)
    {
        JournalVoucherTypeId = journalvouchertypeId;
    }
}

public sealed class JournalVoucherTypeDeletedEvent : DomainEvent
{
    public JournalVoucherTypeId JournalVoucherTypeId { get; }

    public JournalVoucherTypeDeletedEvent(JournalVoucherTypeId journalvouchertypeId)
    {
        JournalVoucherTypeId = journalvouchertypeId;
    }
}
}
