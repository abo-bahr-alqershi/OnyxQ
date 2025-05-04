using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ParameterInventory entity
/// </summary>
public sealed class ParameterInventoryCreatedEvent : DomainEvent
{
    public ParameterInventoryId ParameterInventoryId { get; }

    public ParameterInventoryCreatedEvent(ParameterInventoryId parameterinventoryId)
    {
        ParameterInventoryId = parameterinventoryId;
    }
}

public sealed class ParameterInventoryUpdatedEvent : DomainEvent
{
    public ParameterInventoryId ParameterInventoryId { get; }

    public ParameterInventoryUpdatedEvent(ParameterInventoryId parameterinventoryId)
    {
        ParameterInventoryId = parameterinventoryId;
    }
}

public sealed class ParameterInventoryDeletedEvent : DomainEvent
{
    public ParameterInventoryId ParameterInventoryId { get; }

    public ParameterInventoryDeletedEvent(ParameterInventoryId parameterinventoryId)
    {
        ParameterInventoryId = parameterinventoryId;
    }
}
}
