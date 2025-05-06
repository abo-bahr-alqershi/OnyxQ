using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingPlanMaster entity
/// </summary>
public sealed class OutgoingPlanMasterCreatedEvent : DomainEvent
{
    public OutgoingPlanMasterId OutgoingPlanMasterId { get; }

    public OutgoingPlanMasterCreatedEvent(OutgoingPlanMasterId outgoingplanmasterId)
    {
        OutgoingPlanMasterId = outgoingplanmasterId;
    }
}

public sealed class OutgoingPlanMasterUpdatedEvent : DomainEvent
{
    public OutgoingPlanMasterId OutgoingPlanMasterId { get; }

    public OutgoingPlanMasterUpdatedEvent(OutgoingPlanMasterId outgoingplanmasterId)
    {
        OutgoingPlanMasterId = outgoingplanmasterId;
    }
}

public sealed class OutgoingPlanMasterDeletedEvent : DomainEvent
{
    public OutgoingPlanMasterId OutgoingPlanMasterId { get; }

    public OutgoingPlanMasterDeletedEvent(OutgoingPlanMasterId outgoingplanmasterId)
    {
        OutgoingPlanMasterId = outgoingplanmasterId;
    }
}
}
