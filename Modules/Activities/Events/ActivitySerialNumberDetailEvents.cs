using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Activities.Events
{
/// <summary>
/// Events related to ActivitySerialNumberDetail entity
/// </summary>
public sealed class ActivitySerialNumberDetailCreatedEvent : DomainEvent
{
    public ActivitySerialNumberDetailId ActivitySerialNumberDetailId { get; }

    public ActivitySerialNumberDetailCreatedEvent(ActivitySerialNumberDetailId activityserialnumberdetailId)
    {
        ActivitySerialNumberDetailId = activityserialnumberdetailId;
    }
}

public sealed class ActivitySerialNumberDetailUpdatedEvent : DomainEvent
{
    public ActivitySerialNumberDetailId ActivitySerialNumberDetailId { get; }

    public ActivitySerialNumberDetailUpdatedEvent(ActivitySerialNumberDetailId activityserialnumberdetailId)
    {
        ActivitySerialNumberDetailId = activityserialnumberdetailId;
    }
}

public sealed class ActivitySerialNumberDetailDeletedEvent : DomainEvent
{
    public ActivitySerialNumberDetailId ActivitySerialNumberDetailId { get; }

    public ActivitySerialNumberDetailDeletedEvent(ActivitySerialNumberDetailId activityserialnumberdetailId)
    {
        ActivitySerialNumberDetailId = activityserialnumberdetailId;
    }
}
}
