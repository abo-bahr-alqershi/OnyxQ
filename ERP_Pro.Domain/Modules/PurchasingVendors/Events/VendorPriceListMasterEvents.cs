using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorPriceListMaster entity
/// </summary>
public sealed class VendorPriceListMasterCreatedEvent : DomainEvent
{
    public VendorPriceListMasterId VendorPriceListMasterId { get; }

    public VendorPriceListMasterCreatedEvent(VendorPriceListMasterId vendorpricelistmasterId)
    {
        VendorPriceListMasterId = vendorpricelistmasterId;
    }
}

public sealed class VendorPriceListMasterUpdatedEvent : DomainEvent
{
    public VendorPriceListMasterId VendorPriceListMasterId { get; }

    public VendorPriceListMasterUpdatedEvent(VendorPriceListMasterId vendorpricelistmasterId)
    {
        VendorPriceListMasterId = vendorpricelistmasterId;
    }
}

public sealed class VendorPriceListMasterDeletedEvent : DomainEvent
{
    public VendorPriceListMasterId VendorPriceListMasterId { get; }

    public VendorPriceListMasterDeletedEvent(VendorPriceListMasterId vendorpricelistmasterId)
    {
        VendorPriceListMasterId = vendorpricelistmasterId;
    }
}
}
