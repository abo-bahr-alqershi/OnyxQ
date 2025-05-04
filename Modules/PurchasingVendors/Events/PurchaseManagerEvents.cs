using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseManager entity
/// </summary>
public sealed class PurchaseManagerCreatedEvent : DomainEvent
{
    public PurchaseManagerId PurchaseManagerId { get; }

    public PurchaseManagerCreatedEvent(PurchaseManagerId purchasemanagerId)
    {
        PurchaseManagerId = purchasemanagerId;
    }
}

public sealed class PurchaseManagerUpdatedEvent : DomainEvent
{
    public PurchaseManagerId PurchaseManagerId { get; }

    public PurchaseManagerUpdatedEvent(PurchaseManagerId purchasemanagerId)
    {
        PurchaseManagerId = purchasemanagerId;
    }
}

public sealed class PurchaseManagerDeletedEvent : DomainEvent
{
    public PurchaseManagerId PurchaseManagerId { get; }

    public PurchaseManagerDeletedEvent(PurchaseManagerId purchasemanagerId)
    {
        PurchaseManagerId = purchasemanagerId;
    }
}
}
