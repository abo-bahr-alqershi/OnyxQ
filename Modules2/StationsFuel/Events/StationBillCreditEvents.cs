using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationBillCredit entity
/// </summary>
public sealed class StationBillCreditCreatedEvent : DomainEvent
{
    public StationBillCreditId StationBillCreditId { get; }

    public StationBillCreditCreatedEvent(StationBillCreditId stationbillcreditId)
    {
        StationBillCreditId = stationbillcreditId;
    }
}

public sealed class StationBillCreditUpdatedEvent : DomainEvent
{
    public StationBillCreditId StationBillCreditId { get; }

    public StationBillCreditUpdatedEvent(StationBillCreditId stationbillcreditId)
    {
        StationBillCreditId = stationbillcreditId;
    }
}

public sealed class StationBillCreditDeletedEvent : DomainEvent
{
    public StationBillCreditId StationBillCreditId { get; }

    public StationBillCreditDeletedEvent(StationBillCreditId stationbillcreditId)
    {
        StationBillCreditId = stationbillcreditId;
    }
}
}
