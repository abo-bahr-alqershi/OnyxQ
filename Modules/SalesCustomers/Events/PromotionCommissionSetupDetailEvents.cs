using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionCommissionSetupDetail entity
/// </summary>
public sealed class PromotionCommissionSetupDetailCreatedEvent : DomainEvent
{
    public PromotionCommissionSetupDetailId PromotionCommissionSetupDetailId { get; }

    public PromotionCommissionSetupDetailCreatedEvent(PromotionCommissionSetupDetailId promotioncommissionsetupdetailId)
    {
        PromotionCommissionSetupDetailId = promotioncommissionsetupdetailId;
    }
}

public sealed class PromotionCommissionSetupDetailUpdatedEvent : DomainEvent
{
    public PromotionCommissionSetupDetailId PromotionCommissionSetupDetailId { get; }

    public PromotionCommissionSetupDetailUpdatedEvent(PromotionCommissionSetupDetailId promotioncommissionsetupdetailId)
    {
        PromotionCommissionSetupDetailId = promotioncommissionsetupdetailId;
    }
}

public sealed class PromotionCommissionSetupDetailDeletedEvent : DomainEvent
{
    public PromotionCommissionSetupDetailId PromotionCommissionSetupDetailId { get; }

    public PromotionCommissionSetupDetailDeletedEvent(PromotionCommissionSetupDetailId promotioncommissionsetupdetailId)
    {
        PromotionCommissionSetupDetailId = promotioncommissionsetupdetailId;
    }
}
}
