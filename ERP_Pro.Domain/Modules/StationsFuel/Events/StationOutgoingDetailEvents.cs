using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationOutgoingDetail entity
/// </summary>
public sealed class StationOutgoingDetailCreatedEvent : DomainEvent
{
    public StationOutgoingDetailId StationOutgoingDetailId { get; }

    public StationOutgoingDetailCreatedEvent(StationOutgoingDetailId stationoutgoingdetailId)
    {
        StationOutgoingDetailId = stationoutgoingdetailId;
    }
}

public sealed class StationOutgoingDetailUpdatedEvent : DomainEvent
{
    public StationOutgoingDetailId StationOutgoingDetailId { get; }

    public StationOutgoingDetailUpdatedEvent(StationOutgoingDetailId stationoutgoingdetailId)
    {
        StationOutgoingDetailId = stationoutgoingdetailId;
    }
}

public sealed class StationOutgoingDetailDeletedEvent : DomainEvent
{
    public StationOutgoingDetailId StationOutgoingDetailId { get; }

    public StationOutgoingDetailDeletedEvent(StationOutgoingDetailId stationoutgoingdetailId)
    {
        StationOutgoingDetailId = stationoutgoingdetailId;
    }
}
}
