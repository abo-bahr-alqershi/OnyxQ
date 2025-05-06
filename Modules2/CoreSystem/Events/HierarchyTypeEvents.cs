using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to HierarchyType entity
/// </summary>
public sealed class HierarchyTypeCreatedEvent : DomainEvent
{
    public HierarchyTypeId HierarchyTypeId { get; }

    public HierarchyTypeCreatedEvent(HierarchyTypeId hierarchytypeId)
    {
        HierarchyTypeId = hierarchytypeId;
    }
}

public sealed class HierarchyTypeUpdatedEvent : DomainEvent
{
    public HierarchyTypeId HierarchyTypeId { get; }

    public HierarchyTypeUpdatedEvent(HierarchyTypeId hierarchytypeId)
    {
        HierarchyTypeId = hierarchytypeId;
    }
}

public sealed class HierarchyTypeDeletedEvent : DomainEvent
{
    public HierarchyTypeId HierarchyTypeId { get; }

    public HierarchyTypeDeletedEvent(HierarchyTypeId hierarchytypeId)
    {
        HierarchyTypeId = hierarchytypeId;
    }
}
}
