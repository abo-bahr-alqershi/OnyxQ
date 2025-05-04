using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCollectionConditionMaster entity
/// </summary>
public sealed class SalesmanCollectionConditionMasterCreatedEvent : DomainEvent
{
    public SalesmanCollectionConditionMasterId SalesmanCollectionConditionMasterId { get; }

    public SalesmanCollectionConditionMasterCreatedEvent(SalesmanCollectionConditionMasterId salesmancollectionconditionmasterId)
    {
        SalesmanCollectionConditionMasterId = salesmancollectionconditionmasterId;
    }
}

public sealed class SalesmanCollectionConditionMasterUpdatedEvent : DomainEvent
{
    public SalesmanCollectionConditionMasterId SalesmanCollectionConditionMasterId { get; }

    public SalesmanCollectionConditionMasterUpdatedEvent(SalesmanCollectionConditionMasterId salesmancollectionconditionmasterId)
    {
        SalesmanCollectionConditionMasterId = salesmancollectionconditionmasterId;
    }
}

public sealed class SalesmanCollectionConditionMasterDeletedEvent : DomainEvent
{
    public SalesmanCollectionConditionMasterId SalesmanCollectionConditionMasterId { get; }

    public SalesmanCollectionConditionMasterDeletedEvent(SalesmanCollectionConditionMasterId salesmancollectionconditionmasterId)
    {
        SalesmanCollectionConditionMasterId = salesmancollectionconditionmasterId;
    }
}
}
