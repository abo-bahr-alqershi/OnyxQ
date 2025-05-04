using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorClaimMaster entity
/// </summary>
public sealed class VendorClaimMasterCreatedEvent : DomainEvent
{
    public VendorClaimMasterId VendorClaimMasterId { get; }

    public VendorClaimMasterCreatedEvent(VendorClaimMasterId vendorclaimmasterId)
    {
        VendorClaimMasterId = vendorclaimmasterId;
    }
}

public sealed class VendorClaimMasterUpdatedEvent : DomainEvent
{
    public VendorClaimMasterId VendorClaimMasterId { get; }

    public VendorClaimMasterUpdatedEvent(VendorClaimMasterId vendorclaimmasterId)
    {
        VendorClaimMasterId = vendorclaimmasterId;
    }
}

public sealed class VendorClaimMasterDeletedEvent : DomainEvent
{
    public VendorClaimMasterId VendorClaimMasterId { get; }

    public VendorClaimMasterDeletedEvent(VendorClaimMasterId vendorclaimmasterId)
    {
        VendorClaimMasterId = vendorclaimmasterId;
    }
}
}
