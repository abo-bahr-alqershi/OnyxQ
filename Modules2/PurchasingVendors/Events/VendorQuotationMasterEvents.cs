using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorQuotationMaster entity
/// </summary>
public sealed class VendorQuotationMasterCreatedEvent : DomainEvent
{
    public VendorQuotationMasterId VendorQuotationMasterId { get; }

    public VendorQuotationMasterCreatedEvent(VendorQuotationMasterId vendorquotationmasterId)
    {
        VendorQuotationMasterId = vendorquotationmasterId;
    }
}

public sealed class VendorQuotationMasterUpdatedEvent : DomainEvent
{
    public VendorQuotationMasterId VendorQuotationMasterId { get; }

    public VendorQuotationMasterUpdatedEvent(VendorQuotationMasterId vendorquotationmasterId)
    {
        VendorQuotationMasterId = vendorquotationmasterId;
    }
}

public sealed class VendorQuotationMasterDeletedEvent : DomainEvent
{
    public VendorQuotationMasterId VendorQuotationMasterId { get; }

    public VendorQuotationMasterDeletedEvent(VendorQuotationMasterId vendorquotationmasterId)
    {
        VendorQuotationMasterId = vendorquotationmasterId;
    }
}
}
