using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequest entity
/// </summary>
public sealed class PurchaseRequestCreatedEvent : DomainEvent
{
    public PurchaseRequestId PurchaseRequestId { get; }

    public PurchaseRequestCreatedEvent(PurchaseRequestId purchaserequestId)
    {
        PurchaseRequestId = purchaserequestId;
    }
}

public sealed class PurchaseRequestUpdatedEvent : DomainEvent
{
    public PurchaseRequestId PurchaseRequestId { get; }

    public PurchaseRequestUpdatedEvent(PurchaseRequestId purchaserequestId)
    {
        PurchaseRequestId = purchaserequestId;
    }
}

public sealed class PurchaseRequestDeletedEvent : DomainEvent
{
    public PurchaseRequestId PurchaseRequestId { get; }

    public PurchaseRequestDeletedEvent(PurchaseRequestId purchaserequestId)
    {
        PurchaseRequestId = purchaserequestId;
    }
}
}
