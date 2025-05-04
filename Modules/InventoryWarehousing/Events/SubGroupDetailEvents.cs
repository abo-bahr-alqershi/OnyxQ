using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to SubGroupDetail entity
/// </summary>
public sealed class SubGroupDetailCreatedEvent : DomainEvent
{
    public SubGroupDetailId SubGroupDetailId { get; }

    public SubGroupDetailCreatedEvent(SubGroupDetailId subgroupdetailId)
    {
        SubGroupDetailId = subgroupdetailId;
    }
}

public sealed class SubGroupDetailUpdatedEvent : DomainEvent
{
    public SubGroupDetailId SubGroupDetailId { get; }

    public SubGroupDetailUpdatedEvent(SubGroupDetailId subgroupdetailId)
    {
        SubGroupDetailId = subgroupdetailId;
    }
}

public sealed class SubGroupDetailDeletedEvent : DomainEvent
{
    public SubGroupDetailId SubGroupDetailId { get; }

    public SubGroupDetailDeletedEvent(SubGroupDetailId subgroupdetailId)
    {
        SubGroupDetailId = subgroupdetailId;
    }
}
}
