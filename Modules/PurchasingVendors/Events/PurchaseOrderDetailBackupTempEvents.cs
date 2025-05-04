using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseOrderDetailBackupTemp entity
/// </summary>
public sealed class PurchaseOrderDetailBackupTempCreatedEvent : DomainEvent
{
    public PurchaseOrderDetailBackupTempId PurchaseOrderDetailBackupTempId { get; }

    public PurchaseOrderDetailBackupTempCreatedEvent(PurchaseOrderDetailBackupTempId purchaseorderdetailbackuptempId)
    {
        PurchaseOrderDetailBackupTempId = purchaseorderdetailbackuptempId;
    }
}

public sealed class PurchaseOrderDetailBackupTempUpdatedEvent : DomainEvent
{
    public PurchaseOrderDetailBackupTempId PurchaseOrderDetailBackupTempId { get; }

    public PurchaseOrderDetailBackupTempUpdatedEvent(PurchaseOrderDetailBackupTempId purchaseorderdetailbackuptempId)
    {
        PurchaseOrderDetailBackupTempId = purchaseorderdetailbackuptempId;
    }
}

public sealed class PurchaseOrderDetailBackupTempDeletedEvent : DomainEvent
{
    public PurchaseOrderDetailBackupTempId PurchaseOrderDetailBackupTempId { get; }

    public PurchaseOrderDetailBackupTempDeletedEvent(PurchaseOrderDetailBackupTempId purchaseorderdetailbackuptempId)
    {
        PurchaseOrderDetailBackupTempId = purchaseorderdetailbackuptempId;
    }
}
}
