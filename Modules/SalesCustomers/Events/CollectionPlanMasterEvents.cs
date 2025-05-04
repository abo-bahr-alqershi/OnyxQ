using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectionPlanMaster entity
/// </summary>
public sealed class CollectionPlanMasterCreatedEvent : DomainEvent
{
    public CollectionPlanMasterId CollectionPlanMasterId { get; }

    public CollectionPlanMasterCreatedEvent(CollectionPlanMasterId collectionplanmasterId)
    {
        CollectionPlanMasterId = collectionplanmasterId;
    }
}

public sealed class CollectionPlanMasterUpdatedEvent : DomainEvent
{
    public CollectionPlanMasterId CollectionPlanMasterId { get; }

    public CollectionPlanMasterUpdatedEvent(CollectionPlanMasterId collectionplanmasterId)
    {
        CollectionPlanMasterId = collectionplanmasterId;
    }
}

public sealed class CollectionPlanMasterDeletedEvent : DomainEvent
{
    public CollectionPlanMasterId CollectionPlanMasterId { get; }

    public CollectionPlanMasterDeletedEvent(CollectionPlanMasterId collectionplanmasterId)
    {
        CollectionPlanMasterId = collectionplanmasterId;
    }
}
}
