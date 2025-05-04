using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseRequestBillDetail entity
/// </summary>
public sealed class PurchaseRequestBillDetailCreatedEvent : DomainEvent
{
    public PurchaseRequestBillDetailId PurchaseRequestBillDetailId { get; }

    public PurchaseRequestBillDetailCreatedEvent(PurchaseRequestBillDetailId purchaserequestbilldetailId)
    {
        PurchaseRequestBillDetailId = purchaserequestbilldetailId;
    }
}

public sealed class PurchaseRequestBillDetailUpdatedEvent : DomainEvent
{
    public PurchaseRequestBillDetailId PurchaseRequestBillDetailId { get; }

    public PurchaseRequestBillDetailUpdatedEvent(PurchaseRequestBillDetailId purchaserequestbilldetailId)
    {
        PurchaseRequestBillDetailId = purchaserequestbilldetailId;
    }
}

public sealed class PurchaseRequestBillDetailDeletedEvent : DomainEvent
{
    public PurchaseRequestBillDetailId PurchaseRequestBillDetailId { get; }

    public PurchaseRequestBillDetailDeletedEvent(PurchaseRequestBillDetailId purchaserequestbilldetailId)
    {
        PurchaseRequestBillDetailId = purchaserequestbilldetailId;
    }
}
}
