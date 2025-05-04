using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseOrder entity
/// </summary>
public sealed class PurchaseOrderCreatedEvent : DomainEvent
{
    public PurchaseOrderId PurchaseOrderId { get; }

    public PurchaseOrderCreatedEvent(PurchaseOrderId purchaseorderId)
    {
        PurchaseOrderId = purchaseorderId;
    }
}

public sealed class PurchaseOrderUpdatedEvent : DomainEvent
{
    public PurchaseOrderId PurchaseOrderId { get; }

    public PurchaseOrderUpdatedEvent(PurchaseOrderId purchaseorderId)
    {
        PurchaseOrderId = purchaseorderId;
    }
}

public sealed class PurchaseOrderDeletedEvent : DomainEvent
{
    public PurchaseOrderId PurchaseOrderId { get; }

    public PurchaseOrderDeletedEvent(PurchaseOrderId purchaseorderId)
    {
        PurchaseOrderId = purchaseorderId;
    }
}
}
