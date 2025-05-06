using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationJournalDiffEmployeeMaster entity
/// </summary>
public sealed class StationJournalDiffEmployeeMasterCreatedEvent : DomainEvent
{
    public StationJournalDiffEmployeeMasterId StationJournalDiffEmployeeMasterId { get; }

    public StationJournalDiffEmployeeMasterCreatedEvent(StationJournalDiffEmployeeMasterId stationjournaldiffemployeemasterId)
    {
        StationJournalDiffEmployeeMasterId = stationjournaldiffemployeemasterId;
    }
}

public sealed class StationJournalDiffEmployeeMasterUpdatedEvent : DomainEvent
{
    public StationJournalDiffEmployeeMasterId StationJournalDiffEmployeeMasterId { get; }

    public StationJournalDiffEmployeeMasterUpdatedEvent(StationJournalDiffEmployeeMasterId stationjournaldiffemployeemasterId)
    {
        StationJournalDiffEmployeeMasterId = stationjournaldiffemployeemasterId;
    }
}

public sealed class StationJournalDiffEmployeeMasterDeletedEvent : DomainEvent
{
    public StationJournalDiffEmployeeMasterId StationJournalDiffEmployeeMasterId { get; }

    public StationJournalDiffEmployeeMasterDeletedEvent(StationJournalDiffEmployeeMasterId stationjournaldiffemployeemasterId)
    {
        StationJournalDiffEmployeeMasterId = stationjournaldiffemployeemasterId;
    }
}
}
