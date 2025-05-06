using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to DetailGroup entity
/// </summary>
public sealed class DetailGroupCreatedEvent : DomainEvent
{
    public DetailGroupId DetailGroupId { get; }

    public DetailGroupCreatedEvent(DetailGroupId detailgroupId)
    {
        DetailGroupId = detailgroupId;
    }
}

public sealed class DetailGroupUpdatedEvent : DomainEvent
{
    public DetailGroupId DetailGroupId { get; }

    public DetailGroupUpdatedEvent(DetailGroupId detailgroupId)
    {
        DetailGroupId = detailgroupId;
    }
}

public sealed class DetailGroupDeletedEvent : DomainEvent
{
    public DetailGroupId DetailGroupId { get; }

    public DetailGroupDeletedEvent(DetailGroupId detailgroupId)
    {
        DetailGroupId = detailgroupId;
    }
}
}
