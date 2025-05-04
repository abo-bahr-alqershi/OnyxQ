using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorClaimDetail entity
/// </summary>
public sealed class VendorClaimDetailCreatedEvent : DomainEvent
{
    public VendorClaimDetailId VendorClaimDetailId { get; }

    public VendorClaimDetailCreatedEvent(VendorClaimDetailId vendorclaimdetailId)
    {
        VendorClaimDetailId = vendorclaimdetailId;
    }
}

public sealed class VendorClaimDetailUpdatedEvent : DomainEvent
{
    public VendorClaimDetailId VendorClaimDetailId { get; }

    public VendorClaimDetailUpdatedEvent(VendorClaimDetailId vendorclaimdetailId)
    {
        VendorClaimDetailId = vendorclaimdetailId;
    }
}

public sealed class VendorClaimDetailDeletedEvent : DomainEvent
{
    public VendorClaimDetailId VendorClaimDetailId { get; }

    public VendorClaimDetailDeletedEvent(VendorClaimDetailId vendorclaimdetailId)
    {
        VendorClaimDetailId = vendorclaimdetailId;
    }
}
}
