using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ReservationMaster entity
/// </summary>
public sealed class ReservationMasterCreatedEvent : DomainEvent
{
    public ReservationMasterId ReservationMasterId { get; }

    public ReservationMasterCreatedEvent(ReservationMasterId reservationmasterId)
    {
        ReservationMasterId = reservationmasterId;
    }
}

public sealed class ReservationMasterUpdatedEvent : DomainEvent
{
    public ReservationMasterId ReservationMasterId { get; }

    public ReservationMasterUpdatedEvent(ReservationMasterId reservationmasterId)
    {
        ReservationMasterId = reservationmasterId;
    }
}

public sealed class ReservationMasterDeletedEvent : DomainEvent
{
    public ReservationMasterId ReservationMasterId { get; }

    public ReservationMasterDeletedEvent(ReservationMasterId reservationmasterId)
    {
        ReservationMasterId = reservationmasterId;
    }
}
}
