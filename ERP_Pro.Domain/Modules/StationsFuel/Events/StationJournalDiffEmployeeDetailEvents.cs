using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationJournalDiffEmployeeDetail entity
/// </summary>
public sealed class StationJournalDiffEmployeeDetailCreatedEvent : DomainEvent
{
    public StationJournalDiffEmployeeDetailId StationJournalDiffEmployeeDetailId { get; }

    public StationJournalDiffEmployeeDetailCreatedEvent(StationJournalDiffEmployeeDetailId stationjournaldiffemployeedetailId)
    {
        StationJournalDiffEmployeeDetailId = stationjournaldiffemployeedetailId;
    }
}

public sealed class StationJournalDiffEmployeeDetailUpdatedEvent : DomainEvent
{
    public StationJournalDiffEmployeeDetailId StationJournalDiffEmployeeDetailId { get; }

    public StationJournalDiffEmployeeDetailUpdatedEvent(StationJournalDiffEmployeeDetailId stationjournaldiffemployeedetailId)
    {
        StationJournalDiffEmployeeDetailId = stationjournaldiffemployeedetailId;
    }
}

public sealed class StationJournalDiffEmployeeDetailDeletedEvent : DomainEvent
{
    public StationJournalDiffEmployeeDetailId StationJournalDiffEmployeeDetailId { get; }

    public StationJournalDiffEmployeeDetailDeletedEvent(StationJournalDiffEmployeeDetailId stationjournaldiffemployeedetailId)
    {
        StationJournalDiffEmployeeDetailId = stationjournaldiffemployeedetailId;
    }
}
}
