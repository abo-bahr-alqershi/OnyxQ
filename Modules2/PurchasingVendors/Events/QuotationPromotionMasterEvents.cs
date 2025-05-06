using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationPromotionMaster entity
/// </summary>
public sealed class QuotationPromotionMasterCreatedEvent : DomainEvent
{
    public QuotationPromotionMasterId QuotationPromotionMasterId { get; }

    public QuotationPromotionMasterCreatedEvent(QuotationPromotionMasterId quotationpromotionmasterId)
    {
        QuotationPromotionMasterId = quotationpromotionmasterId;
    }
}

public sealed class QuotationPromotionMasterUpdatedEvent : DomainEvent
{
    public QuotationPromotionMasterId QuotationPromotionMasterId { get; }

    public QuotationPromotionMasterUpdatedEvent(QuotationPromotionMasterId quotationpromotionmasterId)
    {
        QuotationPromotionMasterId = quotationpromotionmasterId;
    }
}

public sealed class QuotationPromotionMasterDeletedEvent : DomainEvent
{
    public QuotationPromotionMasterId QuotationPromotionMasterId { get; }

    public QuotationPromotionMasterDeletedEvent(QuotationPromotionMasterId quotationpromotionmasterId)
    {
        QuotationPromotionMasterId = quotationpromotionmasterId;
    }
}
}
