using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Promoter entity
/// </summary>
public sealed class PromoterCreatedEvent : DomainEvent
{
    public PromoterId PromoterId { get; }

    public PromoterCreatedEvent(PromoterId promoterId)
    {
        PromoterId = promoterId;
    }
}

public sealed class PromoterUpdatedEvent : DomainEvent
{
    public PromoterId PromoterId { get; }

    public PromoterUpdatedEvent(PromoterId promoterId)
    {
        PromoterId = promoterId;
    }
}

public sealed class PromoterDeletedEvent : DomainEvent
{
    public PromoterId PromoterId { get; }

    public PromoterDeletedEvent(PromoterId promoterId)
    {
        PromoterId = promoterId;
    }
}
}
