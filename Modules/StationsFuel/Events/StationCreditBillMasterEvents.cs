using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationCreditBillMaster entity
/// </summary>
public sealed class StationCreditBillMasterCreatedEvent : DomainEvent
{
    public StationCreditBillMasterId StationCreditBillMasterId { get; }

    public StationCreditBillMasterCreatedEvent(StationCreditBillMasterId stationcreditbillmasterId)
    {
        StationCreditBillMasterId = stationcreditbillmasterId;
    }
}

public sealed class StationCreditBillMasterUpdatedEvent : DomainEvent
{
    public StationCreditBillMasterId StationCreditBillMasterId { get; }

    public StationCreditBillMasterUpdatedEvent(StationCreditBillMasterId stationcreditbillmasterId)
    {
        StationCreditBillMasterId = stationcreditbillmasterId;
    }
}

public sealed class StationCreditBillMasterDeletedEvent : DomainEvent
{
    public StationCreditBillMasterId StationCreditBillMasterId { get; }

    public StationCreditBillMasterDeletedEvent(StationCreditBillMasterId stationcreditbillmasterId)
    {
        StationCreditBillMasterId = stationcreditbillmasterId;
    }
}
}
