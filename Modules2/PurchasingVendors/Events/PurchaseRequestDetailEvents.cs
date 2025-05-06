using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestDetail entity
/// </summary>
public sealed class PurchaseRequestDetailCreatedEvent : DomainEvent
{
    public PurchaseRequestDetailId PurchaseRequestDetailId { get; }

    public PurchaseRequestDetailCreatedEvent(PurchaseRequestDetailId purchaserequestdetailId)
    {
        PurchaseRequestDetailId = purchaserequestdetailId;
    }
}

public sealed class PurchaseRequestDetailUpdatedEvent : DomainEvent
{
    public PurchaseRequestDetailId PurchaseRequestDetailId { get; }

    public PurchaseRequestDetailUpdatedEvent(PurchaseRequestDetailId purchaserequestdetailId)
    {
        PurchaseRequestDetailId = purchaserequestdetailId;
    }
}

public sealed class PurchaseRequestDetailDeletedEvent : DomainEvent
{
    public PurchaseRequestDetailId PurchaseRequestDetailId { get; }

    public PurchaseRequestDetailDeletedEvent(PurchaseRequestDetailId purchaserequestdetailId)
    {
        PurchaseRequestDetailId = purchaserequestdetailId;
    }
}
}
