using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationBillDetail entity
/// </summary>
public sealed class StationBillDetailCreatedEvent : DomainEvent
{
    public StationBillDetailId StationBillDetailId { get; }

    public StationBillDetailCreatedEvent(StationBillDetailId stationbilldetailId)
    {
        StationBillDetailId = stationbilldetailId;
    }
}

public sealed class StationBillDetailUpdatedEvent : DomainEvent
{
    public StationBillDetailId StationBillDetailId { get; }

    public StationBillDetailUpdatedEvent(StationBillDetailId stationbilldetailId)
    {
        StationBillDetailId = stationbilldetailId;
    }
}

public sealed class StationBillDetailDeletedEvent : DomainEvent
{
    public StationBillDetailId StationBillDetailId { get; }

    public StationBillDetailDeletedEvent(StationBillDetailId stationbilldetailId)
    {
        StationBillDetailId = stationbilldetailId;
    }
}
}
