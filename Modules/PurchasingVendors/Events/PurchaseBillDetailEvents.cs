using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseBillDetail entity
/// </summary>
public sealed class PurchaseBillDetailCreatedEvent : DomainEvent
{
    public PurchaseBillDetailId PurchaseBillDetailId { get; }

    public PurchaseBillDetailCreatedEvent(PurchaseBillDetailId purchasebilldetailId)
    {
        PurchaseBillDetailId = purchasebilldetailId;
    }
}

public sealed class PurchaseBillDetailUpdatedEvent : DomainEvent
{
    public PurchaseBillDetailId PurchaseBillDetailId { get; }

    public PurchaseBillDetailUpdatedEvent(PurchaseBillDetailId purchasebilldetailId)
    {
        PurchaseBillDetailId = purchasebilldetailId;
    }
}

public sealed class PurchaseBillDetailDeletedEvent : DomainEvent
{
    public PurchaseBillDetailId PurchaseBillDetailId { get; }

    public PurchaseBillDetailDeletedEvent(PurchaseBillDetailId purchasebilldetailId)
    {
        PurchaseBillDetailId = purchasebilldetailId;
    }
}
}
