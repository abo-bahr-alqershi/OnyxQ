using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Activities.Events
{
/// <summary>
/// Events related to ActivityTree entity
/// </summary>
public sealed class ActivityTreeCreatedEvent : DomainEvent
{
    public ActivityTreeId ActivityTreeId { get; }

    public ActivityTreeCreatedEvent(ActivityTreeId activitytreeId)
    {
        ActivityTreeId = activitytreeId;
    }
}

public sealed class ActivityTreeUpdatedEvent : DomainEvent
{
    public ActivityTreeId ActivityTreeId { get; }

    public ActivityTreeUpdatedEvent(ActivityTreeId activitytreeId)
    {
        ActivityTreeId = activitytreeId;
    }
}

public sealed class ActivityTreeDeletedEvent : DomainEvent
{
    public ActivityTreeId ActivityTreeId { get; }

    public ActivityTreeDeletedEvent(ActivityTreeId activitytreeId)
    {
        ActivityTreeId = activitytreeId;
    }
}
}
