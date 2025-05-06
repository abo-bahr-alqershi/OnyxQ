using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to InvoiceDetail entity
/// </summary>
public sealed class InvoiceDetailCreatedEvent : DomainEvent
{
    public InvoiceDetailId InvoiceDetailId { get; }

    public InvoiceDetailCreatedEvent(InvoiceDetailId invoicedetailId)
    {
        InvoiceDetailId = invoicedetailId;
    }
}

public sealed class InvoiceDetailUpdatedEvent : DomainEvent
{
    public InvoiceDetailId InvoiceDetailId { get; }

    public InvoiceDetailUpdatedEvent(InvoiceDetailId invoicedetailId)
    {
        InvoiceDetailId = invoicedetailId;
    }
}

public sealed class InvoiceDetailDeletedEvent : DomainEvent
{
    public InvoiceDetailId InvoiceDetailId { get; }

    public InvoiceDetailDeletedEvent(InvoiceDetailId invoicedetailId)
    {
        InvoiceDetailId = invoicedetailId;
    }
}
}
