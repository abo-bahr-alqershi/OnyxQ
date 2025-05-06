using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchasePlanDetail entity
/// </summary>
public sealed class PurchasePlanDetailCreatedEvent : DomainEvent
{
    public PurchasePlanDetailId PurchasePlanDetailId { get; }

    public PurchasePlanDetailCreatedEvent(PurchasePlanDetailId purchaseplandetailId)
    {
        PurchasePlanDetailId = purchaseplandetailId;
    }
}

public sealed class PurchasePlanDetailUpdatedEvent : DomainEvent
{
    public PurchasePlanDetailId PurchasePlanDetailId { get; }

    public PurchasePlanDetailUpdatedEvent(PurchasePlanDetailId purchaseplandetailId)
    {
        PurchasePlanDetailId = purchaseplandetailId;
    }
}

public sealed class PurchasePlanDetailDeletedEvent : DomainEvent
{
    public PurchasePlanDetailId PurchasePlanDetailId { get; }

    public PurchasePlanDetailDeletedEvent(PurchasePlanDetailId purchaseplandetailId)
    {
        PurchasePlanDetailId = purchaseplandetailId;
    }
}
}
