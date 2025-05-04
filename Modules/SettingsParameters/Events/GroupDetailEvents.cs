using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to GroupDetail entity
/// </summary>
public sealed class GroupDetailCreatedEvent : DomainEvent
{
    public GroupDetailId GroupDetailId { get; }

    public GroupDetailCreatedEvent(GroupDetailId groupdetailId)
    {
        GroupDetailId = groupdetailId;
    }
}

public sealed class GroupDetailUpdatedEvent : DomainEvent
{
    public GroupDetailId GroupDetailId { get; }

    public GroupDetailUpdatedEvent(GroupDetailId groupdetailId)
    {
        GroupDetailId = groupdetailId;
    }
}

public sealed class GroupDetailDeletedEvent : DomainEvent
{
    public GroupDetailId GroupDetailId { get; }

    public GroupDetailDeletedEvent(GroupDetailId groupdetailId)
    {
        GroupDetailId = groupdetailId;
    }
}
}
