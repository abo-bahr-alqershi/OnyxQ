using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCollectionConditionDetail entity
/// </summary>
public sealed class SalesmanCollectionConditionDetailCreatedEvent : DomainEvent
{
    public SalesmanCollectionConditionDetailId SalesmanCollectionConditionDetailId { get; }

    public SalesmanCollectionConditionDetailCreatedEvent(SalesmanCollectionConditionDetailId salesmancollectionconditiondetailId)
    {
        SalesmanCollectionConditionDetailId = salesmancollectionconditiondetailId;
    }
}

public sealed class SalesmanCollectionConditionDetailUpdatedEvent : DomainEvent
{
    public SalesmanCollectionConditionDetailId SalesmanCollectionConditionDetailId { get; }

    public SalesmanCollectionConditionDetailUpdatedEvent(SalesmanCollectionConditionDetailId salesmancollectionconditiondetailId)
    {
        SalesmanCollectionConditionDetailId = salesmancollectionconditiondetailId;
    }
}

public sealed class SalesmanCollectionConditionDetailDeletedEvent : DomainEvent
{
    public SalesmanCollectionConditionDetailId SalesmanCollectionConditionDetailId { get; }

    public SalesmanCollectionConditionDetailDeletedEvent(SalesmanCollectionConditionDetailId salesmancollectionconditiondetailId)
    {
        SalesmanCollectionConditionDetailId = salesmancollectionconditiondetailId;
    }
}
}
