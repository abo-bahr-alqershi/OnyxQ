using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to CompoundItem entity
/// </summary>
public sealed class CompoundItemCreatedEvent : DomainEvent
{
    public CompoundItemId CompoundItemId { get; }

    public CompoundItemCreatedEvent(CompoundItemId compounditemId)
    {
        CompoundItemId = compounditemId;
    }
}

public sealed class CompoundItemUpdatedEvent : DomainEvent
{
    public CompoundItemId CompoundItemId { get; }

    public CompoundItemUpdatedEvent(CompoundItemId compounditemId)
    {
        CompoundItemId = compounditemId;
    }
}

public sealed class CompoundItemDeletedEvent : DomainEvent
{
    public CompoundItemId CompoundItemId { get; }

    public CompoundItemDeletedEvent(CompoundItemId compounditemId)
    {
        CompoundItemId = compounditemId;
    }
}
}
