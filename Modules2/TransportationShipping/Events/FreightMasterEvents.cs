using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to FreightMaster entity
/// </summary>
public sealed class FreightMasterCreatedEvent : DomainEvent
{
    public FreightMasterId FreightMasterId { get; }

    public FreightMasterCreatedEvent(FreightMasterId freightmasterId)
    {
        FreightMasterId = freightmasterId;
    }
}

public sealed class FreightMasterUpdatedEvent : DomainEvent
{
    public FreightMasterId FreightMasterId { get; }

    public FreightMasterUpdatedEvent(FreightMasterId freightmasterId)
    {
        FreightMasterId = freightmasterId;
    }
}

public sealed class FreightMasterDeletedEvent : DomainEvent
{
    public FreightMasterId FreightMasterId { get; }

    public FreightMasterDeletedEvent(FreightMasterId freightmasterId)
    {
        FreightMasterId = freightmasterId;
    }
}
}
