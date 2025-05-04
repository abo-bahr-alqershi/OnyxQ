using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorItem entity
/// </summary>
public sealed class VendorItemCreatedEvent : DomainEvent
{
    public VendorItemId VendorItemId { get; }

    public VendorItemCreatedEvent(VendorItemId vendoritemId)
    {
        VendorItemId = vendoritemId;
    }
}

public sealed class VendorItemUpdatedEvent : DomainEvent
{
    public VendorItemId VendorItemId { get; }

    public VendorItemUpdatedEvent(VendorItemId vendoritemId)
    {
        VendorItemId = vendoritemId;
    }
}

public sealed class VendorItemDeletedEvent : DomainEvent
{
    public VendorItemId VendorItemId { get; }

    public VendorItemDeletedEvent(VendorItemId vendoritemId)
    {
        VendorItemId = vendoritemId;
    }
}
}
