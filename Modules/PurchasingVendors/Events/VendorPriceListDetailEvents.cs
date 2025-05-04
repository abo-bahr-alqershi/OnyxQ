using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorPriceListDetail entity
/// </summary>
public sealed class VendorPriceListDetailCreatedEvent : DomainEvent
{
    public VendorPriceListDetailId VendorPriceListDetailId { get; }

    public VendorPriceListDetailCreatedEvent(VendorPriceListDetailId vendorpricelistdetailId)
    {
        VendorPriceListDetailId = vendorpricelistdetailId;
    }
}

public sealed class VendorPriceListDetailUpdatedEvent : DomainEvent
{
    public VendorPriceListDetailId VendorPriceListDetailId { get; }

    public VendorPriceListDetailUpdatedEvent(VendorPriceListDetailId vendorpricelistdetailId)
    {
        VendorPriceListDetailId = vendorpricelistdetailId;
    }
}

public sealed class VendorPriceListDetailDeletedEvent : DomainEvent
{
    public VendorPriceListDetailId VendorPriceListDetailId { get; }

    public VendorPriceListDetailDeletedEvent(VendorPriceListDetailId vendorpricelistdetailId)
    {
        VendorPriceListDetailId = vendorpricelistdetailId;
    }
}
}
