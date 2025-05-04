using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchasePlanMaster entity
/// </summary>
public sealed class PurchasePlanMasterCreatedEvent : DomainEvent
{
    public PurchasePlanMasterId PurchasePlanMasterId { get; }

    public PurchasePlanMasterCreatedEvent(PurchasePlanMasterId purchaseplanmasterId)
    {
        PurchasePlanMasterId = purchaseplanmasterId;
    }
}

public sealed class PurchasePlanMasterUpdatedEvent : DomainEvent
{
    public PurchasePlanMasterId PurchasePlanMasterId { get; }

    public PurchasePlanMasterUpdatedEvent(PurchasePlanMasterId purchaseplanmasterId)
    {
        PurchasePlanMasterId = purchaseplanmasterId;
    }
}

public sealed class PurchasePlanMasterDeletedEvent : DomainEvent
{
    public PurchasePlanMasterId PurchasePlanMasterId { get; }

    public PurchasePlanMasterDeletedEvent(PurchasePlanMasterId purchaseplanmasterId)
    {
        PurchasePlanMasterId = purchaseplanmasterId;
    }
}
}
