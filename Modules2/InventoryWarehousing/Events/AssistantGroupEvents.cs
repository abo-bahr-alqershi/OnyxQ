using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to AssistantGroup entity
/// </summary>
public sealed class AssistantGroupCreatedEvent : DomainEvent
{
    public AssistantGroupId AssistantGroupId { get; }

    public AssistantGroupCreatedEvent(AssistantGroupId assistantgroupId)
    {
        AssistantGroupId = assistantgroupId;
    }
}

public sealed class AssistantGroupUpdatedEvent : DomainEvent
{
    public AssistantGroupId AssistantGroupId { get; }

    public AssistantGroupUpdatedEvent(AssistantGroupId assistantgroupId)
    {
        AssistantGroupId = assistantgroupId;
    }
}

public sealed class AssistantGroupDeletedEvent : DomainEvent
{
    public AssistantGroupId AssistantGroupId { get; }

    public AssistantGroupDeletedEvent(AssistantGroupId assistantgroupId)
    {
        AssistantGroupId = assistantgroupId;
    }
}
}
