using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Hierarchy entity
/// </summary>
public sealed class HierarchyCreatedEvent : DomainEvent
{
    public HierarchyId HierarchyId { get; }

    public HierarchyCreatedEvent(HierarchyId hierarchyId)
    {
        HierarchyId = hierarchyId;
    }
}

public sealed class HierarchyUpdatedEvent : DomainEvent
{
    public HierarchyId HierarchyId { get; }

    public HierarchyUpdatedEvent(HierarchyId hierarchyId)
    {
        HierarchyId = hierarchyId;
    }
}

public sealed class HierarchyDeletedEvent : DomainEvent
{
    public HierarchyId HierarchyId { get; }

    public HierarchyDeletedEvent(HierarchyId hierarchyId)
    {
        HierarchyId = hierarchyId;
    }
}
}
