using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Activities.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Events
{
/// <summary>
/// Events related to ActivityGroup entity
/// </summary>
public sealed class ActivityGroupCreatedEvent : DomainEvent
{
    public ActivityGroupId ActivityGroupId { get; }

    public ActivityGroupCreatedEvent(ActivityGroupId activitygroupId)
    {
        ActivityGroupId = activitygroupId;
    }
}

public sealed class ActivityGroupUpdatedEvent : DomainEvent
{
    public ActivityGroupId ActivityGroupId { get; }

    public ActivityGroupUpdatedEvent(ActivityGroupId activitygroupId)
    {
        ActivityGroupId = activitygroupId;
    }
}

public sealed class ActivityGroupDeletedEvent : DomainEvent
{
    public ActivityGroupId ActivityGroupId { get; }

    public ActivityGroupDeletedEvent(ActivityGroupId activitygroupId)
    {
        ActivityGroupId = activitygroupId;
    }
}
}
