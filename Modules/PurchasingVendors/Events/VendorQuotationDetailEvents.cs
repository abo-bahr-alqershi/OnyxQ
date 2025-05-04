using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorQuotationDetail entity
/// </summary>
public sealed class VendorQuotationDetailCreatedEvent : DomainEvent
{
    public VendorQuotationDetailId VendorQuotationDetailId { get; }

    public VendorQuotationDetailCreatedEvent(VendorQuotationDetailId vendorquotationdetailId)
    {
        VendorQuotationDetailId = vendorquotationdetailId;
    }
}

public sealed class VendorQuotationDetailUpdatedEvent : DomainEvent
{
    public VendorQuotationDetailId VendorQuotationDetailId { get; }

    public VendorQuotationDetailUpdatedEvent(VendorQuotationDetailId vendorquotationdetailId)
    {
        VendorQuotationDetailId = vendorquotationdetailId;
    }
}

public sealed class VendorQuotationDetailDeletedEvent : DomainEvent
{
    public VendorQuotationDetailId VendorQuotationDetailId { get; }

    public VendorQuotationDetailDeletedEvent(VendorQuotationDetailId vendorquotationdetailId)
    {
        VendorQuotationDetailId = vendorquotationdetailId;
    }
}
}
