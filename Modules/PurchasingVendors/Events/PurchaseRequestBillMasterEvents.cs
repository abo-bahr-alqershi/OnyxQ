using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestBillMaster entity
/// </summary>
public sealed class PurchaseRequestBillMasterCreatedEvent : DomainEvent
{
    public PurchaseRequestBillMasterId PurchaseRequestBillMasterId { get; }

    public PurchaseRequestBillMasterCreatedEvent(PurchaseRequestBillMasterId purchaserequestbillmasterId)
    {
        PurchaseRequestBillMasterId = purchaserequestbillmasterId;
    }
}

public sealed class PurchaseRequestBillMasterUpdatedEvent : DomainEvent
{
    public PurchaseRequestBillMasterId PurchaseRequestBillMasterId { get; }

    public PurchaseRequestBillMasterUpdatedEvent(PurchaseRequestBillMasterId purchaserequestbillmasterId)
    {
        PurchaseRequestBillMasterId = purchaserequestbillmasterId;
    }
}

public sealed class PurchaseRequestBillMasterDeletedEvent : DomainEvent
{
    public PurchaseRequestBillMasterId PurchaseRequestBillMasterId { get; }

    public PurchaseRequestBillMasterDeletedEvent(PurchaseRequestBillMasterId purchaserequestbillmasterId)
    {
        PurchaseRequestBillMasterId = purchaserequestbillmasterId;
    }
}
}
