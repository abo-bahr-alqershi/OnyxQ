using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationPromotionDetail entity
/// </summary>
public sealed class QuotationPromotionDetailCreatedEvent : DomainEvent
{
    public QuotationPromotionDetailId QuotationPromotionDetailId { get; }

    public QuotationPromotionDetailCreatedEvent(QuotationPromotionDetailId quotationpromotiondetailId)
    {
        QuotationPromotionDetailId = quotationpromotiondetailId;
    }
}

public sealed class QuotationPromotionDetailUpdatedEvent : DomainEvent
{
    public QuotationPromotionDetailId QuotationPromotionDetailId { get; }

    public QuotationPromotionDetailUpdatedEvent(QuotationPromotionDetailId quotationpromotiondetailId)
    {
        QuotationPromotionDetailId = quotationpromotiondetailId;
    }
}

public sealed class QuotationPromotionDetailDeletedEvent : DomainEvent
{
    public QuotationPromotionDetailId QuotationPromotionDetailId { get; }

    public QuotationPromotionDetailDeletedEvent(QuotationPromotionDetailId quotationpromotiondetailId)
    {
        QuotationPromotionDetailId = quotationpromotiondetailId;
    }
}
}
