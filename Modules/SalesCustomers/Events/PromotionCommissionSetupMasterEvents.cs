using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionCommissionSetupMaster entity
/// </summary>
public sealed class PromotionCommissionSetupMasterCreatedEvent : DomainEvent
{
    public PromotionCommissionSetupMasterId PromotionCommissionSetupMasterId { get; }

    public PromotionCommissionSetupMasterCreatedEvent(PromotionCommissionSetupMasterId promotioncommissionsetupmasterId)
    {
        PromotionCommissionSetupMasterId = promotioncommissionsetupmasterId;
    }
}

public sealed class PromotionCommissionSetupMasterUpdatedEvent : DomainEvent
{
    public PromotionCommissionSetupMasterId PromotionCommissionSetupMasterId { get; }

    public PromotionCommissionSetupMasterUpdatedEvent(PromotionCommissionSetupMasterId promotioncommissionsetupmasterId)
    {
        PromotionCommissionSetupMasterId = promotioncommissionsetupmasterId;
    }
}

public sealed class PromotionCommissionSetupMasterDeletedEvent : DomainEvent
{
    public PromotionCommissionSetupMasterId PromotionCommissionSetupMasterId { get; }

    public PromotionCommissionSetupMasterDeletedEvent(PromotionCommissionSetupMasterId promotioncommissionsetupmasterId)
    {
        PromotionCommissionSetupMasterId = promotioncommissionsetupmasterId;
    }
}
}
