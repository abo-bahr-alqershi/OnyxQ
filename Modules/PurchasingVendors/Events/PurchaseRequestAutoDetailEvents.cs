using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestAutoDetail entity
/// </summary>
public sealed class PurchaseRequestAutoDetailCreatedEvent : DomainEvent
{
    public PurchaseRequestAutoDetailId PurchaseRequestAutoDetailId { get; }

    public PurchaseRequestAutoDetailCreatedEvent(PurchaseRequestAutoDetailId purchaserequestautodetailId)
    {
        PurchaseRequestAutoDetailId = purchaserequestautodetailId;
    }
}

public sealed class PurchaseRequestAutoDetailUpdatedEvent : DomainEvent
{
    public PurchaseRequestAutoDetailId PurchaseRequestAutoDetailId { get; }

    public PurchaseRequestAutoDetailUpdatedEvent(PurchaseRequestAutoDetailId purchaserequestautodetailId)
    {
        PurchaseRequestAutoDetailId = purchaserequestautodetailId;
    }
}

public sealed class PurchaseRequestAutoDetailDeletedEvent : DomainEvent
{
    public PurchaseRequestAutoDetailId PurchaseRequestAutoDetailId { get; }

    public PurchaseRequestAutoDetailDeletedEvent(PurchaseRequestAutoDetailId purchaserequestautodetailId)
    {
        PurchaseRequestAutoDetailId = purchaserequestautodetailId;
    }
}
}
