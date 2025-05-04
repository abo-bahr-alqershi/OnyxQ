using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationPromotionSubDetail entity
/// </summary>
public sealed class QuotationPromotionSubDetailCreatedEvent : DomainEvent
{
    public QuotationPromotionSubDetailId QuotationPromotionSubDetailId { get; }

    public QuotationPromotionSubDetailCreatedEvent(QuotationPromotionSubDetailId quotationpromotionsubdetailId)
    {
        QuotationPromotionSubDetailId = quotationpromotionsubdetailId;
    }
}

public sealed class QuotationPromotionSubDetailUpdatedEvent : DomainEvent
{
    public QuotationPromotionSubDetailId QuotationPromotionSubDetailId { get; }

    public QuotationPromotionSubDetailUpdatedEvent(QuotationPromotionSubDetailId quotationpromotionsubdetailId)
    {
        QuotationPromotionSubDetailId = quotationpromotionsubdetailId;
    }
}

public sealed class QuotationPromotionSubDetailDeletedEvent : DomainEvent
{
    public QuotationPromotionSubDetailId QuotationPromotionSubDetailId { get; }

    public QuotationPromotionSubDetailDeletedEvent(QuotationPromotionSubDetailId quotationpromotionsubdetailId)
    {
        QuotationPromotionSubDetailId = quotationpromotionsubdetailId;
    }
}
}
