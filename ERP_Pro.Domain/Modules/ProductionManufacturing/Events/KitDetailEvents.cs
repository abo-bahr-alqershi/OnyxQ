using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to KitDetail entity
/// </summary>
public sealed class KitDetailCreatedEvent : DomainEvent
{
    public KitDetailId KitDetailId { get; }

    public KitDetailCreatedEvent(KitDetailId kitdetailId)
    {
        KitDetailId = kitdetailId;
    }
}

public sealed class KitDetailUpdatedEvent : DomainEvent
{
    public KitDetailId KitDetailId { get; }

    public KitDetailUpdatedEvent(KitDetailId kitdetailId)
    {
        KitDetailId = kitdetailId;
    }
}

public sealed class KitDetailDeletedEvent : DomainEvent
{
    public KitDetailId KitDetailId { get; }

    public KitDetailDeletedEvent(KitDetailId kitdetailId)
    {
        KitDetailId = kitdetailId;
    }
}
}
