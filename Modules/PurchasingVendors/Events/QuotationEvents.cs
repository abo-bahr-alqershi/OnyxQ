using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to Quotation entity
/// </summary>
public sealed class QuotationCreatedEvent : DomainEvent
{
    public QuotationId QuotationId { get; }

    public QuotationCreatedEvent(QuotationId quotationId)
    {
        QuotationId = quotationId;
    }
}

public sealed class QuotationUpdatedEvent : DomainEvent
{
    public QuotationId QuotationId { get; }

    public QuotationUpdatedEvent(QuotationId quotationId)
    {
        QuotationId = quotationId;
    }
}

public sealed class QuotationDeletedEvent : DomainEvent
{
    public QuotationId QuotationId { get; }

    public QuotationDeletedEvent(QuotationId quotationId)
    {
        QuotationId = quotationId;
    }
}
}
