using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ParameterMobileInventory entity
/// </summary>
public sealed class ParameterMobileInventoryCreatedEvent : DomainEvent
{
    public ParameterMobileInventoryId ParameterMobileInventoryId { get; }

    public ParameterMobileInventoryCreatedEvent(ParameterMobileInventoryId parametermobileinventoryId)
    {
        ParameterMobileInventoryId = parametermobileinventoryId;
    }
}

public sealed class ParameterMobileInventoryUpdatedEvent : DomainEvent
{
    public ParameterMobileInventoryId ParameterMobileInventoryId { get; }

    public ParameterMobileInventoryUpdatedEvent(ParameterMobileInventoryId parametermobileinventoryId)
    {
        ParameterMobileInventoryId = parametermobileinventoryId;
    }
}

public sealed class ParameterMobileInventoryDeletedEvent : DomainEvent
{
    public ParameterMobileInventoryId ParameterMobileInventoryId { get; }

    public ParameterMobileInventoryDeletedEvent(ParameterMobileInventoryId parametermobileinventoryId)
    {
        ParameterMobileInventoryId = parametermobileinventoryId;
    }
}
}
