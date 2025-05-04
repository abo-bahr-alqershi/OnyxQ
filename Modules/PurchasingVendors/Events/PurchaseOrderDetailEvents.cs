using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseOrderDetail entity
/// </summary>
public sealed class PurchaseOrderDetailCreatedEvent : DomainEvent
{
    public PurchaseOrderDetailId PurchaseOrderDetailId { get; }

    public PurchaseOrderDetailCreatedEvent(PurchaseOrderDetailId purchaseorderdetailId)
    {
        PurchaseOrderDetailId = purchaseorderdetailId;
    }
}

public sealed class PurchaseOrderDetailUpdatedEvent : DomainEvent
{
    public PurchaseOrderDetailId PurchaseOrderDetailId { get; }

    public PurchaseOrderDetailUpdatedEvent(PurchaseOrderDetailId purchaseorderdetailId)
    {
        PurchaseOrderDetailId = purchaseorderdetailId;
    }
}

public sealed class PurchaseOrderDetailDeletedEvent : DomainEvent
{
    public PurchaseOrderDetailId PurchaseOrderDetailId { get; }

    public PurchaseOrderDetailDeletedEvent(PurchaseOrderDetailId purchaseorderdetailId)
    {
        PurchaseOrderDetailId = purchaseorderdetailId;
    }
}
}
