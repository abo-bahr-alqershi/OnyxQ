using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryAssemblyType entity
/// </summary>
public sealed class InventoryAssemblyTypeCreatedEvent : DomainEvent
{
    public InventoryAssemblyTypeId InventoryAssemblyTypeId { get; }

    public InventoryAssemblyTypeCreatedEvent(InventoryAssemblyTypeId inventoryassemblytypeId)
    {
        InventoryAssemblyTypeId = inventoryassemblytypeId;
    }
}

public sealed class InventoryAssemblyTypeUpdatedEvent : DomainEvent
{
    public InventoryAssemblyTypeId InventoryAssemblyTypeId { get; }

    public InventoryAssemblyTypeUpdatedEvent(InventoryAssemblyTypeId inventoryassemblytypeId)
    {
        InventoryAssemblyTypeId = inventoryassemblytypeId;
    }
}

public sealed class InventoryAssemblyTypeDeletedEvent : DomainEvent
{
    public InventoryAssemblyTypeId InventoryAssemblyTypeId { get; }

    public InventoryAssemblyTypeDeletedEvent(InventoryAssemblyTypeId inventoryassemblytypeId)
    {
        InventoryAssemblyTypeId = inventoryassemblytypeId;
    }
}
}
