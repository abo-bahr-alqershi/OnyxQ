using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PurchaseOrderType entity
/// </summary>
public sealed class PurchaseOrderTypeCreatedEvent : DomainEvent
{
    public PurchaseOrderTypeId PurchaseOrderTypeId { get; }

    public PurchaseOrderTypeCreatedEvent(PurchaseOrderTypeId purchaseordertypeId)
    {
        PurchaseOrderTypeId = purchaseordertypeId;
    }
}

public sealed class PurchaseOrderTypeUpdatedEvent : DomainEvent
{
    public PurchaseOrderTypeId PurchaseOrderTypeId { get; }

    public PurchaseOrderTypeUpdatedEvent(PurchaseOrderTypeId purchaseordertypeId)
    {
        PurchaseOrderTypeId = purchaseordertypeId;
    }
}

public sealed class PurchaseOrderTypeDeletedEvent : DomainEvent
{
    public PurchaseOrderTypeId PurchaseOrderTypeId { get; }

    public PurchaseOrderTypeDeletedEvent(PurchaseOrderTypeId purchaseordertypeId)
    {
        PurchaseOrderTypeId = purchaseordertypeId;
    }
}
}
