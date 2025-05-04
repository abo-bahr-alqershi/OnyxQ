using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionCommissionCalculationMaster entity
/// </summary>
public sealed class PromotionCommissionCalculationMasterCreatedEvent : DomainEvent
{
    public PromotionCommissionCalculationMasterId PromotionCommissionCalculationMasterId { get; }

    public PromotionCommissionCalculationMasterCreatedEvent(PromotionCommissionCalculationMasterId promotioncommissioncalculationmasterId)
    {
        PromotionCommissionCalculationMasterId = promotioncommissioncalculationmasterId;
    }
}

public sealed class PromotionCommissionCalculationMasterUpdatedEvent : DomainEvent
{
    public PromotionCommissionCalculationMasterId PromotionCommissionCalculationMasterId { get; }

    public PromotionCommissionCalculationMasterUpdatedEvent(PromotionCommissionCalculationMasterId promotioncommissioncalculationmasterId)
    {
        PromotionCommissionCalculationMasterId = promotioncommissioncalculationmasterId;
    }
}

public sealed class PromotionCommissionCalculationMasterDeletedEvent : DomainEvent
{
    public PromotionCommissionCalculationMasterId PromotionCommissionCalculationMasterId { get; }

    public PromotionCommissionCalculationMasterDeletedEvent(PromotionCommissionCalculationMasterId promotioncommissioncalculationmasterId)
    {
        PromotionCommissionCalculationMasterId = promotioncommissioncalculationmasterId;
    }
}
}
