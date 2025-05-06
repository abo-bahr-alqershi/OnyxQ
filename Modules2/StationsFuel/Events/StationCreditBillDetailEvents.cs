using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCreditBillDetail entity
/// </summary>
public sealed class StationCreditBillDetailCreatedEvent : DomainEvent
{
    public StationCreditBillDetailId StationCreditBillDetailId { get; }

    public StationCreditBillDetailCreatedEvent(StationCreditBillDetailId stationcreditbilldetailId)
    {
        StationCreditBillDetailId = stationcreditbilldetailId;
    }
}

public sealed class StationCreditBillDetailUpdatedEvent : DomainEvent
{
    public StationCreditBillDetailId StationCreditBillDetailId { get; }

    public StationCreditBillDetailUpdatedEvent(StationCreditBillDetailId stationcreditbilldetailId)
    {
        StationCreditBillDetailId = stationcreditbilldetailId;
    }
}

public sealed class StationCreditBillDetailDeletedEvent : DomainEvent
{
    public StationCreditBillDetailId StationCreditBillDetailId { get; }

    public StationCreditBillDetailDeletedEvent(StationCreditBillDetailId stationcreditbilldetailId)
    {
        StationCreditBillDetailId = stationcreditbilldetailId;
    }
}
}
