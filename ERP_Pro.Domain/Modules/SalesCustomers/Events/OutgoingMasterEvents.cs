using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutgoingMaster entity
/// </summary>
public sealed class OutgoingMasterCreatedEvent : DomainEvent
{
    public OutgoingMasterId OutgoingMasterId { get; }

    public OutgoingMasterCreatedEvent(OutgoingMasterId outgoingmasterId)
    {
        OutgoingMasterId = outgoingmasterId;
    }
}

public sealed class OutgoingMasterUpdatedEvent : DomainEvent
{
    public OutgoingMasterId OutgoingMasterId { get; }

    public OutgoingMasterUpdatedEvent(OutgoingMasterId outgoingmasterId)
    {
        OutgoingMasterId = outgoingmasterId;
    }
}

public sealed class OutgoingMasterDeletedEvent : DomainEvent
{
    public OutgoingMasterId OutgoingMasterId { get; }

    public OutgoingMasterDeletedEvent(OutgoingMasterId outgoingmasterId)
    {
        OutgoingMasterId = outgoingmasterId;
    }
}
}
