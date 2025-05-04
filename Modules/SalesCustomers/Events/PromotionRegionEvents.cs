using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionRegion entity
/// </summary>
public sealed class PromotionRegionCreatedEvent : DomainEvent
{
    public PromotionRegionId PromotionRegionId { get; }

    public PromotionRegionCreatedEvent(PromotionRegionId promotionregionId)
    {
        PromotionRegionId = promotionregionId;
    }
}

public sealed class PromotionRegionUpdatedEvent : DomainEvent
{
    public PromotionRegionId PromotionRegionId { get; }

    public PromotionRegionUpdatedEvent(PromotionRegionId promotionregionId)
    {
        PromotionRegionId = promotionregionId;
    }
}

public sealed class PromotionRegionDeletedEvent : DomainEvent
{
    public PromotionRegionId PromotionRegionId { get; }

    public PromotionRegionDeletedEvent(PromotionRegionId promotionregionId)
    {
        PromotionRegionId = promotionregionId;
    }
}
}
