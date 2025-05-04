using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationPromotionGroupDetail entity
/// </summary>
public sealed class QuotationPromotionGroupDetailCreatedEvent : DomainEvent
{
    public QuotationPromotionGroupDetailId QuotationPromotionGroupDetailId { get; }

    public QuotationPromotionGroupDetailCreatedEvent(QuotationPromotionGroupDetailId quotationpromotiongroupdetailId)
    {
        QuotationPromotionGroupDetailId = quotationpromotiongroupdetailId;
    }
}

public sealed class QuotationPromotionGroupDetailUpdatedEvent : DomainEvent
{
    public QuotationPromotionGroupDetailId QuotationPromotionGroupDetailId { get; }

    public QuotationPromotionGroupDetailUpdatedEvent(QuotationPromotionGroupDetailId quotationpromotiongroupdetailId)
    {
        QuotationPromotionGroupDetailId = quotationpromotiongroupdetailId;
    }
}

public sealed class QuotationPromotionGroupDetailDeletedEvent : DomainEvent
{
    public QuotationPromotionGroupDetailId QuotationPromotionGroupDetailId { get; }

    public QuotationPromotionGroupDetailDeletedEvent(QuotationPromotionGroupDetailId quotationpromotiongroupdetailId)
    {
        QuotationPromotionGroupDetailId = quotationpromotiongroupdetailId;
    }
}
}
