using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectionPlan entity
/// </summary>
public sealed class CollectionPlanCreatedEvent : DomainEvent
{
    public CollectionPlanId CollectionPlanId { get; }

    public CollectionPlanCreatedEvent(CollectionPlanId collectionplanId)
    {
        CollectionPlanId = collectionplanId;
    }
}

public sealed class CollectionPlanUpdatedEvent : DomainEvent
{
    public CollectionPlanId CollectionPlanId { get; }

    public CollectionPlanUpdatedEvent(CollectionPlanId collectionplanId)
    {
        CollectionPlanId = collectionplanId;
    }
}

public sealed class CollectionPlanDeletedEvent : DomainEvent
{
    public CollectionPlanId CollectionPlanId { get; }

    public CollectionPlanDeletedEvent(CollectionPlanId collectionplanId)
    {
        CollectionPlanId = collectionplanId;
    }
}
}
