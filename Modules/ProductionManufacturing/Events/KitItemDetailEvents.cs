using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to KitItemDetail entity
/// </summary>
public sealed class KitItemDetailCreatedEvent : DomainEvent
{
    public KitItemDetailId KitItemDetailId { get; }

    public KitItemDetailCreatedEvent(KitItemDetailId kititemdetailId)
    {
        KitItemDetailId = kititemdetailId;
    }
}

public sealed class KitItemDetailUpdatedEvent : DomainEvent
{
    public KitItemDetailId KitItemDetailId { get; }

    public KitItemDetailUpdatedEvent(KitItemDetailId kititemdetailId)
    {
        KitItemDetailId = kititemdetailId;
    }
}

public sealed class KitItemDetailDeletedEvent : DomainEvent
{
    public KitItemDetailId KitItemDetailId { get; }

    public KitItemDetailDeletedEvent(KitItemDetailId kititemdetailId)
    {
        KitItemDetailId = kititemdetailId;
    }
}
}
