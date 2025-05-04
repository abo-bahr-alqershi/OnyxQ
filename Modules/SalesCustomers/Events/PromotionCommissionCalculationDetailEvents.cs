using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionCommissionCalculationDetail entity
/// </summary>
public sealed class PromotionCommissionCalculationDetailCreatedEvent : DomainEvent
{
    public PromotionCommissionCalculationDetailId PromotionCommissionCalculationDetailId { get; }

    public PromotionCommissionCalculationDetailCreatedEvent(PromotionCommissionCalculationDetailId promotioncommissioncalculationdetailId)
    {
        PromotionCommissionCalculationDetailId = promotioncommissioncalculationdetailId;
    }
}

public sealed class PromotionCommissionCalculationDetailUpdatedEvent : DomainEvent
{
    public PromotionCommissionCalculationDetailId PromotionCommissionCalculationDetailId { get; }

    public PromotionCommissionCalculationDetailUpdatedEvent(PromotionCommissionCalculationDetailId promotioncommissioncalculationdetailId)
    {
        PromotionCommissionCalculationDetailId = promotioncommissioncalculationdetailId;
    }
}

public sealed class PromotionCommissionCalculationDetailDeletedEvent : DomainEvent
{
    public PromotionCommissionCalculationDetailId PromotionCommissionCalculationDetailId { get; }

    public PromotionCommissionCalculationDetailDeletedEvent(PromotionCommissionCalculationDetailId promotioncommissioncalculationdetailId)
    {
        PromotionCommissionCalculationDetailId = promotioncommissioncalculationdetailId;
    }
}
}
