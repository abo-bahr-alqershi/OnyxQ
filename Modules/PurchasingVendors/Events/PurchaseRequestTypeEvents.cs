using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestType entity
/// </summary>
public sealed class PurchaseRequestTypeCreatedEvent : DomainEvent
{
    public PurchaseRequestTypeId PurchaseRequestTypeId { get; }

    public PurchaseRequestTypeCreatedEvent(PurchaseRequestTypeId purchaserequesttypeId)
    {
        PurchaseRequestTypeId = purchaserequesttypeId;
    }
}

public sealed class PurchaseRequestTypeUpdatedEvent : DomainEvent
{
    public PurchaseRequestTypeId PurchaseRequestTypeId { get; }

    public PurchaseRequestTypeUpdatedEvent(PurchaseRequestTypeId purchaserequesttypeId)
    {
        PurchaseRequestTypeId = purchaserequesttypeId;
    }
}

public sealed class PurchaseRequestTypeDeletedEvent : DomainEvent
{
    public PurchaseRequestTypeId PurchaseRequestTypeId { get; }

    public PurchaseRequestTypeDeletedEvent(PurchaseRequestTypeId purchaserequesttypeId)
    {
        PurchaseRequestTypeId = purchaserequesttypeId;
    }
}
}
