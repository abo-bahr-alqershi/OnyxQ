using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingPlanDetail entity
/// </summary>
public sealed class OutgoingPlanDetailCreatedEvent : DomainEvent
{
    public OutgoingPlanDetailId OutgoingPlanDetailId { get; }

    public OutgoingPlanDetailCreatedEvent(OutgoingPlanDetailId outgoingplandetailId)
    {
        OutgoingPlanDetailId = outgoingplandetailId;
    }
}

public sealed class OutgoingPlanDetailUpdatedEvent : DomainEvent
{
    public OutgoingPlanDetailId OutgoingPlanDetailId { get; }

    public OutgoingPlanDetailUpdatedEvent(OutgoingPlanDetailId outgoingplandetailId)
    {
        OutgoingPlanDetailId = outgoingplandetailId;
    }
}

public sealed class OutgoingPlanDetailDeletedEvent : DomainEvent
{
    public OutgoingPlanDetailId OutgoingPlanDetailId { get; }

    public OutgoingPlanDetailDeletedEvent(OutgoingPlanDetailId outgoingplandetailId)
    {
        OutgoingPlanDetailId = outgoingplandetailId;
    }
}
}
