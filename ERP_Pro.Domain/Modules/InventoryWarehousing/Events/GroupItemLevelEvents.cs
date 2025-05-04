using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GroupItemLevel entity
/// </summary>
public sealed class GroupItemLevelCreatedEvent : DomainEvent
{
    public GroupItemLevelId GroupItemLevelId { get; }

    public GroupItemLevelCreatedEvent(GroupItemLevelId groupitemlevelId)
    {
        GroupItemLevelId = groupitemlevelId;
    }
}

public sealed class GroupItemLevelUpdatedEvent : DomainEvent
{
    public GroupItemLevelId GroupItemLevelId { get; }

    public GroupItemLevelUpdatedEvent(GroupItemLevelId groupitemlevelId)
    {
        GroupItemLevelId = groupitemlevelId;
    }
}

public sealed class GroupItemLevelDeletedEvent : DomainEvent
{
    public GroupItemLevelId GroupItemLevelId { get; }

    public GroupItemLevelDeletedEvent(GroupItemLevelId groupitemlevelId)
    {
        GroupItemLevelId = groupitemlevelId;
    }
}
}
