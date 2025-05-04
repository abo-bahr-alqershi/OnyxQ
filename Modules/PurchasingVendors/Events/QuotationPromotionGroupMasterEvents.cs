using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationPromotionGroupMaster entity
/// </summary>
public sealed class QuotationPromotionGroupMasterCreatedEvent : DomainEvent
{
    public QuotationPromotionGroupMasterId QuotationPromotionGroupMasterId { get; }

    public QuotationPromotionGroupMasterCreatedEvent(QuotationPromotionGroupMasterId quotationpromotiongroupmasterId)
    {
        QuotationPromotionGroupMasterId = quotationpromotiongroupmasterId;
    }
}

public sealed class QuotationPromotionGroupMasterUpdatedEvent : DomainEvent
{
    public QuotationPromotionGroupMasterId QuotationPromotionGroupMasterId { get; }

    public QuotationPromotionGroupMasterUpdatedEvent(QuotationPromotionGroupMasterId quotationpromotiongroupmasterId)
    {
        QuotationPromotionGroupMasterId = quotationpromotiongroupmasterId;
    }
}

public sealed class QuotationPromotionGroupMasterDeletedEvent : DomainEvent
{
    public QuotationPromotionGroupMasterId QuotationPromotionGroupMasterId { get; }

    public QuotationPromotionGroupMasterDeletedEvent(QuotationPromotionGroupMasterId quotationpromotiongroupmasterId)
    {
        QuotationPromotionGroupMasterId = quotationpromotiongroupmasterId;
    }
}
}
