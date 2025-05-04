using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorLimitPurchase entity
/// </summary>
public sealed class VendorLimitPurchaseCreatedEvent : DomainEvent
{
    public VendorLimitPurchaseId VendorLimitPurchaseId { get; }

    public VendorLimitPurchaseCreatedEvent(VendorLimitPurchaseId vendorlimitpurchaseId)
    {
        VendorLimitPurchaseId = vendorlimitpurchaseId;
    }
}

public sealed class VendorLimitPurchaseUpdatedEvent : DomainEvent
{
    public VendorLimitPurchaseId VendorLimitPurchaseId { get; }

    public VendorLimitPurchaseUpdatedEvent(VendorLimitPurchaseId vendorlimitpurchaseId)
    {
        VendorLimitPurchaseId = vendorlimitpurchaseId;
    }
}

public sealed class VendorLimitPurchaseDeletedEvent : DomainEvent
{
    public VendorLimitPurchaseId VendorLimitPurchaseId { get; }

    public VendorLimitPurchaseDeletedEvent(VendorLimitPurchaseId vendorlimitpurchaseId)
    {
        VendorLimitPurchaseId = vendorlimitpurchaseId;
    }
}
}
