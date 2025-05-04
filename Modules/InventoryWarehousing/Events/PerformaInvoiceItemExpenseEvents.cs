using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceItemExpense entity
/// </summary>
public sealed class PerformaInvoiceItemExpenseCreatedEvent : DomainEvent
{
    public PerformaInvoiceItemExpenseId PerformaInvoiceItemExpenseId { get; }

    public PerformaInvoiceItemExpenseCreatedEvent(PerformaInvoiceItemExpenseId performainvoiceitemexpenseId)
    {
        PerformaInvoiceItemExpenseId = performainvoiceitemexpenseId;
    }
}

public sealed class PerformaInvoiceItemExpenseUpdatedEvent : DomainEvent
{
    public PerformaInvoiceItemExpenseId PerformaInvoiceItemExpenseId { get; }

    public PerformaInvoiceItemExpenseUpdatedEvent(PerformaInvoiceItemExpenseId performainvoiceitemexpenseId)
    {
        PerformaInvoiceItemExpenseId = performainvoiceitemexpenseId;
    }
}

public sealed class PerformaInvoiceItemExpenseDeletedEvent : DomainEvent
{
    public PerformaInvoiceItemExpenseId PerformaInvoiceItemExpenseId { get; }

    public PerformaInvoiceItemExpenseDeletedEvent(PerformaInvoiceItemExpenseId performainvoiceitemexpenseId)
    {
        PerformaInvoiceItemExpenseId = performainvoiceitemexpenseId;
    }
}
}
