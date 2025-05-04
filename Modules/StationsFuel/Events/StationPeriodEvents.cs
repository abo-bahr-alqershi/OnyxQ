using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationPeriod entity
/// </summary>
public sealed class StationPeriodCreatedEvent : DomainEvent
{
    public StationPeriodId StationPeriodId { get; }

    public StationPeriodCreatedEvent(StationPeriodId stationperiodId)
    {
        StationPeriodId = stationperiodId;
    }
}

public sealed class StationPeriodUpdatedEvent : DomainEvent
{
    public StationPeriodId StationPeriodId { get; }

    public StationPeriodUpdatedEvent(StationPeriodId stationperiodId)
    {
        StationPeriodId = stationperiodId;
    }
}

public sealed class StationPeriodDeletedEvent : DomainEvent
{
    public StationPeriodId StationPeriodId { get; }

    public StationPeriodDeletedEvent(StationPeriodId stationperiodId)
    {
        StationPeriodId = stationperiodId;
    }
}
}
