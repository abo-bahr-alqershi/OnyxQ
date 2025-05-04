using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to KitItem entity
/// </summary>
public sealed class KitItemCreatedEvent : DomainEvent
{
    public KitItemId KitItemId { get; }

    public KitItemCreatedEvent(KitItemId kititemId)
    {
        KitItemId = kititemId;
    }
}

public sealed class KitItemUpdatedEvent : DomainEvent
{
    public KitItemId KitItemId { get; }

    public KitItemUpdatedEvent(KitItemId kititemId)
    {
        KitItemId = kititemId;
    }
}

public sealed class KitItemDeletedEvent : DomainEvent
{
    public KitItemId KitItemId { get; }

    public KitItemDeletedEvent(KitItemId kititemId)
    {
        KitItemId = kititemId;
    }
}
}
