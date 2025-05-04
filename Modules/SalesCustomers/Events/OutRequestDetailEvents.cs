using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutRequestDetail entity
/// </summary>
public sealed class OutRequestDetailCreatedEvent : DomainEvent
{
    public OutRequestDetailId OutRequestDetailId { get; }

    public OutRequestDetailCreatedEvent(OutRequestDetailId outrequestdetailId)
    {
        OutRequestDetailId = outrequestdetailId;
    }
}

public sealed class OutRequestDetailUpdatedEvent : DomainEvent
{
    public OutRequestDetailId OutRequestDetailId { get; }

    public OutRequestDetailUpdatedEvent(OutRequestDetailId outrequestdetailId)
    {
        OutRequestDetailId = outrequestdetailId;
    }
}

public sealed class OutRequestDetailDeletedEvent : DomainEvent
{
    public OutRequestDetailId OutRequestDetailId { get; }

    public OutRequestDetailDeletedEvent(OutRequestDetailId outrequestdetailId)
    {
        OutRequestDetailId = outrequestdetailId;
    }
}
}
