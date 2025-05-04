using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to TenderDetail entity
/// </summary>
public sealed class TenderDetailCreatedEvent : DomainEvent
{
    public TenderDetailId TenderDetailId { get; }

    public TenderDetailCreatedEvent(TenderDetailId tenderdetailId)
    {
        TenderDetailId = tenderdetailId;
    }
}

public sealed class TenderDetailUpdatedEvent : DomainEvent
{
    public TenderDetailId TenderDetailId { get; }

    public TenderDetailUpdatedEvent(TenderDetailId tenderdetailId)
    {
        TenderDetailId = tenderdetailId;
    }
}

public sealed class TenderDetailDeletedEvent : DomainEvent
{
    public TenderDetailId TenderDetailId { get; }

    public TenderDetailDeletedEvent(TenderDetailId tenderdetailId)
    {
        TenderDetailId = tenderdetailId;
    }
}
}
