using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCounterEmployee entity
/// </summary>
public sealed class StationCounterEmployeeCreatedEvent : DomainEvent
{
    public StationCounterEmployeeId StationCounterEmployeeId { get; }

    public StationCounterEmployeeCreatedEvent(StationCounterEmployeeId stationcounteremployeeId)
    {
        StationCounterEmployeeId = stationcounteremployeeId;
    }
}

public sealed class StationCounterEmployeeUpdatedEvent : DomainEvent
{
    public StationCounterEmployeeId StationCounterEmployeeId { get; }

    public StationCounterEmployeeUpdatedEvent(StationCounterEmployeeId stationcounteremployeeId)
    {
        StationCounterEmployeeId = stationcounteremployeeId;
    }
}

public sealed class StationCounterEmployeeDeletedEvent : DomainEvent
{
    public StationCounterEmployeeId StationCounterEmployeeId { get; }

    public StationCounterEmployeeDeletedEvent(StationCounterEmployeeId stationcounteremployeeId)
    {
        StationCounterEmployeeId = stationcounteremployeeId;
    }
}
}
