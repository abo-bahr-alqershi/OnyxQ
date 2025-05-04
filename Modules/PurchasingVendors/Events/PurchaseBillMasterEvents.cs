using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseBillMaster entity
/// </summary>
public sealed class PurchaseBillMasterCreatedEvent : DomainEvent
{
    public PurchaseBillMasterId PurchaseBillMasterId { get; }

    public PurchaseBillMasterCreatedEvent(PurchaseBillMasterId purchasebillmasterId)
    {
        PurchaseBillMasterId = purchasebillmasterId;
    }
}

public sealed class PurchaseBillMasterUpdatedEvent : DomainEvent
{
    public PurchaseBillMasterId PurchaseBillMasterId { get; }

    public PurchaseBillMasterUpdatedEvent(PurchaseBillMasterId purchasebillmasterId)
    {
        PurchaseBillMasterId = purchasebillmasterId;
    }
}

public sealed class PurchaseBillMasterDeletedEvent : DomainEvent
{
    public PurchaseBillMasterId PurchaseBillMasterId { get; }

    public PurchaseBillMasterDeletedEvent(PurchaseBillMasterId purchasebillmasterId)
    {
        PurchaseBillMasterId = purchasebillmasterId;
    }
}
}
