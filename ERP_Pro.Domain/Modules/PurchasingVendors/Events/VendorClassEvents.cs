using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorClass entity
/// </summary>
public sealed class VendorClassCreatedEvent : DomainEvent
{
    public VendorClassId VendorClassId { get; }

    public VendorClassCreatedEvent(VendorClassId vendorclassId)
    {
        VendorClassId = vendorclassId;
    }
}

public sealed class VendorClassUpdatedEvent : DomainEvent
{
    public VendorClassId VendorClassId { get; }

    public VendorClassUpdatedEvent(VendorClassId vendorclassId)
    {
        VendorClassId = vendorclassId;
    }
}

public sealed class VendorClassDeletedEvent : DomainEvent
{
    public VendorClassId VendorClassId { get; }

    public VendorClassDeletedEvent(VendorClassId vendorclassId)
    {
        VendorClassId = vendorclassId;
    }
}
}
