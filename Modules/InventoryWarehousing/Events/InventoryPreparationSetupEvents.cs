using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryPreparationSetup entity
/// </summary>
public sealed class InventoryPreparationSetupCreatedEvent : DomainEvent
{
    public InventoryPreparationSetupId InventoryPreparationSetupId { get; }

    public InventoryPreparationSetupCreatedEvent(InventoryPreparationSetupId inventorypreparationsetupId)
    {
        InventoryPreparationSetupId = inventorypreparationsetupId;
    }
}

public sealed class InventoryPreparationSetupUpdatedEvent : DomainEvent
{
    public InventoryPreparationSetupId InventoryPreparationSetupId { get; }

    public InventoryPreparationSetupUpdatedEvent(InventoryPreparationSetupId inventorypreparationsetupId)
    {
        InventoryPreparationSetupId = inventorypreparationsetupId;
    }
}

public sealed class InventoryPreparationSetupDeletedEvent : DomainEvent
{
    public InventoryPreparationSetupId InventoryPreparationSetupId { get; }

    public InventoryPreparationSetupDeletedEvent(InventoryPreparationSetupId inventorypreparationsetupId)
    {
        InventoryPreparationSetupId = inventorypreparationsetupId;
    }
}
}
