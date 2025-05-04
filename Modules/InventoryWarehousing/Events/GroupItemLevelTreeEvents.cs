using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GroupItemLevelTree entity
/// </summary>
public sealed class GroupItemLevelTreeCreatedEvent : DomainEvent
{
    public GroupItemLevelTreeId GroupItemLevelTreeId { get; }

    public GroupItemLevelTreeCreatedEvent(GroupItemLevelTreeId groupitemleveltreeId)
    {
        GroupItemLevelTreeId = groupitemleveltreeId;
    }
}

public sealed class GroupItemLevelTreeUpdatedEvent : DomainEvent
{
    public GroupItemLevelTreeId GroupItemLevelTreeId { get; }

    public GroupItemLevelTreeUpdatedEvent(GroupItemLevelTreeId groupitemleveltreeId)
    {
        GroupItemLevelTreeId = groupitemleveltreeId;
    }
}

public sealed class GroupItemLevelTreeDeletedEvent : DomainEvent
{
    public GroupItemLevelTreeId GroupItemLevelTreeId { get; }

    public GroupItemLevelTreeDeletedEvent(GroupItemLevelTreeId groupitemleveltreeId)
    {
        GroupItemLevelTreeId = groupitemleveltreeId;
    }
}
}
