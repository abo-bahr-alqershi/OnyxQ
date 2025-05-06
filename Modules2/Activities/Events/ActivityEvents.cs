using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Activities.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Events
{
/// <summary>
/// Events related to Activity entity
/// </summary>
public sealed class ActivityCreatedEvent : DomainEvent
{
    public ActivityId ActivityId { get; }

    public ActivityCreatedEvent(ActivityId activityId)
    {
        ActivityId = activityId;
    }
}

public sealed class ActivityUpdatedEvent : DomainEvent
{
    public ActivityId ActivityId { get; }

    public ActivityUpdatedEvent(ActivityId activityId)
    {
        ActivityId = activityId;
    }
}

public sealed class ActivityDeletedEvent : DomainEvent
{
    public ActivityId ActivityId { get; }

    public ActivityDeletedEvent(ActivityId activityId)
    {
        ActivityId = activityId;
    }
}
}
