using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillJournal entity
/// </summary>
public sealed class PerformaInvoiceBillJournalCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillJournalId PerformaInvoiceBillJournalId { get; }

    public PerformaInvoiceBillJournalCreatedEvent(PerformaInvoiceBillJournalId performainvoicebilljournalId)
    {
        PerformaInvoiceBillJournalId = performainvoicebilljournalId;
    }
}

public sealed class PerformaInvoiceBillJournalUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillJournalId PerformaInvoiceBillJournalId { get; }

    public PerformaInvoiceBillJournalUpdatedEvent(PerformaInvoiceBillJournalId performainvoicebilljournalId)
    {
        PerformaInvoiceBillJournalId = performainvoicebilljournalId;
    }
}

public sealed class PerformaInvoiceBillJournalDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillJournalId PerformaInvoiceBillJournalId { get; }

    public PerformaInvoiceBillJournalDeletedEvent(PerformaInvoiceBillJournalId performainvoicebilljournalId)
    {
        PerformaInvoiceBillJournalId = performainvoicebilljournalId;
    }
}
}
