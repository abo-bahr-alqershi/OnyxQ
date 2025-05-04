using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationBillMaster entity
/// </summary>
public sealed class StationBillMasterCreatedEvent : DomainEvent
{
    public StationBillMasterId StationBillMasterId { get; }

    public StationBillMasterCreatedEvent(StationBillMasterId stationbillmasterId)
    {
        StationBillMasterId = stationbillmasterId;
    }
}

public sealed class StationBillMasterUpdatedEvent : DomainEvent
{
    public StationBillMasterId StationBillMasterId { get; }

    public StationBillMasterUpdatedEvent(StationBillMasterId stationbillmasterId)
    {
        StationBillMasterId = stationbillmasterId;
    }
}

public sealed class StationBillMasterDeletedEvent : DomainEvent
{
    public StationBillMasterId StationBillMasterId { get; }

    public StationBillMasterDeletedEvent(StationBillMasterId stationbillmasterId)
    {
        StationBillMasterId = stationbillmasterId;
    }
}
}
