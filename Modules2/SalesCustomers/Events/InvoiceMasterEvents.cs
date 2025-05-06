using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to InvoiceMaster entity
/// </summary>
public sealed class InvoiceMasterCreatedEvent : DomainEvent
{
    public InvoiceMasterId InvoiceMasterId { get; }

    public InvoiceMasterCreatedEvent(InvoiceMasterId invoicemasterId)
    {
        InvoiceMasterId = invoicemasterId;
    }
}

public sealed class InvoiceMasterUpdatedEvent : DomainEvent
{
    public InvoiceMasterId InvoiceMasterId { get; }

    public InvoiceMasterUpdatedEvent(InvoiceMasterId invoicemasterId)
    {
        InvoiceMasterId = invoicemasterId;
    }
}

public sealed class InvoiceMasterDeletedEvent : DomainEvent
{
    public InvoiceMasterId InvoiceMasterId { get; }

    public InvoiceMasterDeletedEvent(InvoiceMasterId invoicemasterId)
    {
        InvoiceMasterId = invoicemasterId;
    }
}
}
