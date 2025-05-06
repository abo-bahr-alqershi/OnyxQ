using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PricingLevel entity
/// </summary>
public sealed class PricingLevelCreatedEvent : DomainEvent
{
    public PricingLevelId PricingLevelId { get; }

    public PricingLevelCreatedEvent(PricingLevelId pricinglevelId)
    {
        PricingLevelId = pricinglevelId;
    }
}

public sealed class PricingLevelUpdatedEvent : DomainEvent
{
    public PricingLevelId PricingLevelId { get; }

    public PricingLevelUpdatedEvent(PricingLevelId pricinglevelId)
    {
        PricingLevelId = pricinglevelId;
    }
}

public sealed class PricingLevelDeletedEvent : DomainEvent
{
    public PricingLevelId PricingLevelId { get; }

    public PricingLevelDeletedEvent(PricingLevelId pricinglevelId)
    {
        PricingLevelId = pricinglevelId;
    }
}
}
