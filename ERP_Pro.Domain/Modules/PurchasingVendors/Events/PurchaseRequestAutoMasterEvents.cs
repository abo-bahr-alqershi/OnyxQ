using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestAutoMaster entity
/// </summary>
public sealed class PurchaseRequestAutoMasterCreatedEvent : DomainEvent
{
    public PurchaseRequestAutoMasterId PurchaseRequestAutoMasterId { get; }

    public PurchaseRequestAutoMasterCreatedEvent(PurchaseRequestAutoMasterId purchaserequestautomasterId)
    {
        PurchaseRequestAutoMasterId = purchaserequestautomasterId;
    }
}

public sealed class PurchaseRequestAutoMasterUpdatedEvent : DomainEvent
{
    public PurchaseRequestAutoMasterId PurchaseRequestAutoMasterId { get; }

    public PurchaseRequestAutoMasterUpdatedEvent(PurchaseRequestAutoMasterId purchaserequestautomasterId)
    {
        PurchaseRequestAutoMasterId = purchaserequestautomasterId;
    }
}

public sealed class PurchaseRequestAutoMasterDeletedEvent : DomainEvent
{
    public PurchaseRequestAutoMasterId PurchaseRequestAutoMasterId { get; }

    public PurchaseRequestAutoMasterDeletedEvent(PurchaseRequestAutoMasterId purchaserequestautomasterId)
    {
        PurchaseRequestAutoMasterId = purchaserequestautomasterId;
    }
}
}
