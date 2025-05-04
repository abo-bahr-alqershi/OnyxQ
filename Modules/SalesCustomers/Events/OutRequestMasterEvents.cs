using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to OutRequestMaster entity
/// </summary>
public sealed class OutRequestMasterCreatedEvent : DomainEvent
{
    public OutRequestMasterId OutRequestMasterId { get; }

    public OutRequestMasterCreatedEvent(OutRequestMasterId outrequestmasterId)
    {
        OutRequestMasterId = outrequestmasterId;
    }
}

public sealed class OutRequestMasterUpdatedEvent : DomainEvent
{
    public OutRequestMasterId OutRequestMasterId { get; }

    public OutRequestMasterUpdatedEvent(OutRequestMasterId outrequestmasterId)
    {
        OutRequestMasterId = outrequestmasterId;
    }
}

public sealed class OutRequestMasterDeletedEvent : DomainEvent
{
    public OutRequestMasterId OutRequestMasterId { get; }

    public OutRequestMasterDeletedEvent(OutRequestMasterId outrequestmasterId)
    {
        OutRequestMasterId = outrequestmasterId;
    }
}
}
