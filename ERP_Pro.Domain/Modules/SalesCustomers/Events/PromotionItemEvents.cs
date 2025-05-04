using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PromotionItem entity
/// </summary>
public sealed class PromotionItemCreatedEvent : DomainEvent
{
    public PromotionItemId PromotionItemId { get; }

    public PromotionItemCreatedEvent(PromotionItemId promotionitemId)
    {
        PromotionItemId = promotionitemId;
    }
}

public sealed class PromotionItemUpdatedEvent : DomainEvent
{
    public PromotionItemId PromotionItemId { get; }

    public PromotionItemUpdatedEvent(PromotionItemId promotionitemId)
    {
        PromotionItemId = promotionitemId;
    }
}

public sealed class PromotionItemDeletedEvent : DomainEvent
{
    public PromotionItemId PromotionItemId { get; }

    public PromotionItemDeletedEvent(PromotionItemId promotionitemId)
    {
        PromotionItemId = promotionitemId;
    }
}
}
