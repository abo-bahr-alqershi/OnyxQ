using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ReservationDetail entity
/// </summary>
public sealed class ReservationDetailCreatedEvent : DomainEvent
{
    public ReservationDetailId ReservationDetailId { get; }

    public ReservationDetailCreatedEvent(ReservationDetailId reservationdetailId)
    {
        ReservationDetailId = reservationdetailId;
    }
}

public sealed class ReservationDetailUpdatedEvent : DomainEvent
{
    public ReservationDetailId ReservationDetailId { get; }

    public ReservationDetailUpdatedEvent(ReservationDetailId reservationdetailId)
    {
        ReservationDetailId = reservationdetailId;
    }
}

public sealed class ReservationDetailDeletedEvent : DomainEvent
{
    public ReservationDetailId ReservationDetailId { get; }

    public ReservationDetailDeletedEvent(ReservationDetailId reservationdetailId)
    {
        ReservationDetailId = reservationdetailId;
    }
}
}
