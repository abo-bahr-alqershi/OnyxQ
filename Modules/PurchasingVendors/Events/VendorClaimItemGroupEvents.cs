using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorClaimItemGroup entity
/// </summary>
public sealed class VendorClaimItemGroupCreatedEvent : DomainEvent
{
    public VendorClaimItemGroupId VendorClaimItemGroupId { get; }

    public VendorClaimItemGroupCreatedEvent(VendorClaimItemGroupId vendorclaimitemgroupId)
    {
        VendorClaimItemGroupId = vendorclaimitemgroupId;
    }
}

public sealed class VendorClaimItemGroupUpdatedEvent : DomainEvent
{
    public VendorClaimItemGroupId VendorClaimItemGroupId { get; }

    public VendorClaimItemGroupUpdatedEvent(VendorClaimItemGroupId vendorclaimitemgroupId)
    {
        VendorClaimItemGroupId = vendorclaimitemgroupId;
    }
}

public sealed class VendorClaimItemGroupDeletedEvent : DomainEvent
{
    public VendorClaimItemGroupId VendorClaimItemGroupId { get; }

    public VendorClaimItemGroupDeletedEvent(VendorClaimItemGroupId vendorclaimitemgroupId)
    {
        VendorClaimItemGroupId = vendorclaimitemgroupId;
    }
}
}
