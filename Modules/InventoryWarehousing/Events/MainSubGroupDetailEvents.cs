using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to MainSubGroupDetail entity
/// </summary>
public sealed class MainSubGroupDetailCreatedEvent : DomainEvent
{
    public MainSubGroupDetailId MainSubGroupDetailId { get; }

    public MainSubGroupDetailCreatedEvent(MainSubGroupDetailId mainsubgroupdetailId)
    {
        MainSubGroupDetailId = mainsubgroupdetailId;
    }
}

public sealed class MainSubGroupDetailUpdatedEvent : DomainEvent
{
    public MainSubGroupDetailId MainSubGroupDetailId { get; }

    public MainSubGroupDetailUpdatedEvent(MainSubGroupDetailId mainsubgroupdetailId)
    {
        MainSubGroupDetailId = mainsubgroupdetailId;
    }
}

public sealed class MainSubGroupDetailDeletedEvent : DomainEvent
{
    public MainSubGroupDetailId MainSubGroupDetailId { get; }

    public MainSubGroupDetailDeletedEvent(MainSubGroupDetailId mainsubgroupdetailId)
    {
        MainSubGroupDetailId = mainsubgroupdetailId;
    }
}
}
