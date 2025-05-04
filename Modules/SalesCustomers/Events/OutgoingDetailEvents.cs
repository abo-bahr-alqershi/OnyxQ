using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingDetail entity
/// </summary>
public sealed class OutgoingDetailCreatedEvent : DomainEvent
{
    public OutgoingDetailId OutgoingDetailId { get; }

    public OutgoingDetailCreatedEvent(OutgoingDetailId outgoingdetailId)
    {
        OutgoingDetailId = outgoingdetailId;
    }
}

public sealed class OutgoingDetailUpdatedEvent : DomainEvent
{
    public OutgoingDetailId OutgoingDetailId { get; }

    public OutgoingDetailUpdatedEvent(OutgoingDetailId outgoingdetailId)
    {
        OutgoingDetailId = outgoingdetailId;
    }
}

public sealed class OutgoingDetailDeletedEvent : DomainEvent
{
    public OutgoingDetailId OutgoingDetailId { get; }

    public OutgoingDetailDeletedEvent(OutgoingDetailId outgoingdetailId)
    {
        OutgoingDetailId = outgoingdetailId;
    }
}
}
