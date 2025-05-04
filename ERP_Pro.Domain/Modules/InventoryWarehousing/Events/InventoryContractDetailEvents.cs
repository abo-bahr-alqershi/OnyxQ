using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryContractDetail entity
/// </summary>
public sealed class InventoryContractDetailCreatedEvent : DomainEvent
{
    public InventoryContractDetailId InventoryContractDetailId { get; }

    public InventoryContractDetailCreatedEvent(InventoryContractDetailId inventorycontractdetailId)
    {
        InventoryContractDetailId = inventorycontractdetailId;
    }
}

public sealed class InventoryContractDetailUpdatedEvent : DomainEvent
{
    public InventoryContractDetailId InventoryContractDetailId { get; }

    public InventoryContractDetailUpdatedEvent(InventoryContractDetailId inventorycontractdetailId)
    {
        InventoryContractDetailId = inventorycontractdetailId;
    }
}

public sealed class InventoryContractDetailDeletedEvent : DomainEvent
{
    public InventoryContractDetailId InventoryContractDetailId { get; }

    public InventoryContractDetailDeletedEvent(InventoryContractDetailId inventorycontractdetailId)
    {
        InventoryContractDetailId = inventorycontractdetailId;
    }
}
}
