using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to IncomingOutgoingMaster entity
/// </summary>
public sealed class IncomingOutgoingMasterCreatedEvent : DomainEvent
{
    public IncomingOutgoingMasterId IncomingOutgoingMasterId { get; }

    public IncomingOutgoingMasterCreatedEvent(IncomingOutgoingMasterId incomingoutgoingmasterId)
    {
        IncomingOutgoingMasterId = incomingoutgoingmasterId;
    }
}

public sealed class IncomingOutgoingMasterUpdatedEvent : DomainEvent
{
    public IncomingOutgoingMasterId IncomingOutgoingMasterId { get; }

    public IncomingOutgoingMasterUpdatedEvent(IncomingOutgoingMasterId incomingoutgoingmasterId)
    {
        IncomingOutgoingMasterId = incomingoutgoingmasterId;
    }
}

public sealed class IncomingOutgoingMasterDeletedEvent : DomainEvent
{
    public IncomingOutgoingMasterId IncomingOutgoingMasterId { get; }

    public IncomingOutgoingMasterDeletedEvent(IncomingOutgoingMasterId incomingoutgoingmasterId)
    {
        IncomingOutgoingMasterId = incomingoutgoingmasterId;
    }
}
}
