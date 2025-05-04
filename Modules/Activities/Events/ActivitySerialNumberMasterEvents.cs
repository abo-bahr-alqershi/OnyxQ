using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Activities.Events
{
/// <summary>
/// Events related to ActivitySerialNumberMaster entity
/// </summary>
public sealed class ActivitySerialNumberMasterCreatedEvent : DomainEvent
{
    public ActivitySerialNumberMasterId ActivitySerialNumberMasterId { get; }

    public ActivitySerialNumberMasterCreatedEvent(ActivitySerialNumberMasterId activityserialnumbermasterId)
    {
        ActivitySerialNumberMasterId = activityserialnumbermasterId;
    }
}

public sealed class ActivitySerialNumberMasterUpdatedEvent : DomainEvent
{
    public ActivitySerialNumberMasterId ActivitySerialNumberMasterId { get; }

    public ActivitySerialNumberMasterUpdatedEvent(ActivitySerialNumberMasterId activityserialnumbermasterId)
    {
        ActivitySerialNumberMasterId = activityserialnumbermasterId;
    }
}

public sealed class ActivitySerialNumberMasterDeletedEvent : DomainEvent
{
    public ActivitySerialNumberMasterId ActivitySerialNumberMasterId { get; }

    public ActivitySerialNumberMasterDeletedEvent(ActivitySerialNumberMasterId activityserialnumbermasterId)
    {
        ActivitySerialNumberMasterId = activityserialnumbermasterId;
    }
}
}
