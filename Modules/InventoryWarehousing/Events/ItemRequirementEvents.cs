using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemRequirement entity
/// </summary>
public sealed class ItemRequirementCreatedEvent : DomainEvent
{
    public ItemRequirementId ItemRequirementId { get; }

    public ItemRequirementCreatedEvent(ItemRequirementId itemrequirementId)
    {
        ItemRequirementId = itemrequirementId;
    }
}

public sealed class ItemRequirementUpdatedEvent : DomainEvent
{
    public ItemRequirementId ItemRequirementId { get; }

    public ItemRequirementUpdatedEvent(ItemRequirementId itemrequirementId)
    {
        ItemRequirementId = itemrequirementId;
    }
}

public sealed class ItemRequirementDeletedEvent : DomainEvent
{
    public ItemRequirementId ItemRequirementId { get; }

    public ItemRequirementDeletedEvent(ItemRequirementId itemrequirementId)
    {
        ItemRequirementId = itemrequirementId;
    }
}
}
