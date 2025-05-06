using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to AlternativeGroup entity
/// </summary>
public sealed class AlternativeGroupCreatedEvent : DomainEvent
{
    public AlternativeGroupId AlternativeGroupId { get; }

    public AlternativeGroupCreatedEvent(AlternativeGroupId alternativegroupId)
    {
        AlternativeGroupId = alternativegroupId;
    }
}

public sealed class AlternativeGroupUpdatedEvent : DomainEvent
{
    public AlternativeGroupId AlternativeGroupId { get; }

    public AlternativeGroupUpdatedEvent(AlternativeGroupId alternativegroupId)
    {
        AlternativeGroupId = alternativegroupId;
    }
}

public sealed class AlternativeGroupDeletedEvent : DomainEvent
{
    public AlternativeGroupId AlternativeGroupId { get; }

    public AlternativeGroupDeletedEvent(AlternativeGroupId alternativegroupId)
    {
        AlternativeGroupId = alternativegroupId;
    }
}
}
