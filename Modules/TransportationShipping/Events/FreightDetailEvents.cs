using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Events
{
/// <summary>
/// Events related to FreightDetail entity
/// </summary>
public sealed class FreightDetailCreatedEvent : DomainEvent
{
    public FreightDetailId FreightDetailId { get; }

    public FreightDetailCreatedEvent(FreightDetailId freightdetailId)
    {
        FreightDetailId = freightdetailId;
    }
}

public sealed class FreightDetailUpdatedEvent : DomainEvent
{
    public FreightDetailId FreightDetailId { get; }

    public FreightDetailUpdatedEvent(FreightDetailId freightdetailId)
    {
        FreightDetailId = freightdetailId;
    }
}

public sealed class FreightDetailDeletedEvent : DomainEvent
{
    public FreightDetailId FreightDetailId { get; }

    public FreightDetailDeletedEvent(FreightDetailId freightdetailId)
    {
        FreightDetailId = freightdetailId;
    }
}
}
