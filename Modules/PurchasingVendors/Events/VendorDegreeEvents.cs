using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorDegree entity
/// </summary>
public sealed class VendorDegreeCreatedEvent : DomainEvent
{
    public VendorDegreeId VendorDegreeId { get; }

    public VendorDegreeCreatedEvent(VendorDegreeId vendordegreeId)
    {
        VendorDegreeId = vendordegreeId;
    }
}

public sealed class VendorDegreeUpdatedEvent : DomainEvent
{
    public VendorDegreeId VendorDegreeId { get; }

    public VendorDegreeUpdatedEvent(VendorDegreeId vendordegreeId)
    {
        VendorDegreeId = vendordegreeId;
    }
}

public sealed class VendorDegreeDeletedEvent : DomainEvent
{
    public VendorDegreeId VendorDegreeId { get; }

    public VendorDegreeDeletedEvent(VendorDegreeId vendordegreeId)
    {
        VendorDegreeId = vendordegreeId;
    }
}
}
