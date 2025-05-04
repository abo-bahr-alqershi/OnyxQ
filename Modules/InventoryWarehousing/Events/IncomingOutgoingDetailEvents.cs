using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to IncomingOutgoingDetail entity
/// </summary>
public sealed class IncomingOutgoingDetailCreatedEvent : DomainEvent
{
    public IncomingOutgoingDetailId IncomingOutgoingDetailId { get; }

    public IncomingOutgoingDetailCreatedEvent(IncomingOutgoingDetailId incomingoutgoingdetailId)
    {
        IncomingOutgoingDetailId = incomingoutgoingdetailId;
    }
}

public sealed class IncomingOutgoingDetailUpdatedEvent : DomainEvent
{
    public IncomingOutgoingDetailId IncomingOutgoingDetailId { get; }

    public IncomingOutgoingDetailUpdatedEvent(IncomingOutgoingDetailId incomingoutgoingdetailId)
    {
        IncomingOutgoingDetailId = incomingoutgoingdetailId;
    }
}

public sealed class IncomingOutgoingDetailDeletedEvent : DomainEvent
{
    public IncomingOutgoingDetailId IncomingOutgoingDetailId { get; }

    public IncomingOutgoingDetailDeletedEvent(IncomingOutgoingDetailId incomingoutgoingdetailId)
    {
        IncomingOutgoingDetailId = incomingoutgoingdetailId;
    }
}
}
