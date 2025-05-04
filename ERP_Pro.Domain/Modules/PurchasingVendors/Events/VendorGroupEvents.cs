using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorGroup entity
/// </summary>
public sealed class VendorGroupCreatedEvent : DomainEvent
{
    public VendorGroupId VendorGroupId { get; }

    public VendorGroupCreatedEvent(VendorGroupId vendorgroupId)
    {
        VendorGroupId = vendorgroupId;
    }
}

public sealed class VendorGroupUpdatedEvent : DomainEvent
{
    public VendorGroupId VendorGroupId { get; }

    public VendorGroupUpdatedEvent(VendorGroupId vendorgroupId)
    {
        VendorGroupId = vendorgroupId;
    }
}

public sealed class VendorGroupDeletedEvent : DomainEvent
{
    public VendorGroupId VendorGroupId { get; }

    public VendorGroupDeletedEvent(VendorGroupId vendorgroupId)
    {
        VendorGroupId = vendorgroupId;
    }
}
}
