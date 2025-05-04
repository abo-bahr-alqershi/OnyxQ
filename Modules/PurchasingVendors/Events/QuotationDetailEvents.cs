using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationDetail entity
/// </summary>
public sealed class QuotationDetailCreatedEvent : DomainEvent
{
    public QuotationDetailId QuotationDetailId { get; }

    public QuotationDetailCreatedEvent(QuotationDetailId quotationdetailId)
    {
        QuotationDetailId = quotationdetailId;
    }
}

public sealed class QuotationDetailUpdatedEvent : DomainEvent
{
    public QuotationDetailId QuotationDetailId { get; }

    public QuotationDetailUpdatedEvent(QuotationDetailId quotationdetailId)
    {
        QuotationDetailId = quotationdetailId;
    }
}

public sealed class QuotationDetailDeletedEvent : DomainEvent
{
    public QuotationDetailId QuotationDetailId { get; }

    public QuotationDetailDeletedEvent(QuotationDetailId quotationdetailId)
    {
        QuotationDetailId = quotationdetailId;
    }
}
}
