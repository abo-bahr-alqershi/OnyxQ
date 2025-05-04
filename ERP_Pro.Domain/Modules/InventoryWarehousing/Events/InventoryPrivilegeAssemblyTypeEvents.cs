using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryPrivilegeAssemblyType entity
/// </summary>
public sealed class InventoryPrivilegeAssemblyTypeCreatedEvent : DomainEvent
{
    public InventoryPrivilegeAssemblyTypeId InventoryPrivilegeAssemblyTypeId { get; }

    public InventoryPrivilegeAssemblyTypeCreatedEvent(InventoryPrivilegeAssemblyTypeId inventoryprivilegeassemblytypeId)
    {
        InventoryPrivilegeAssemblyTypeId = inventoryprivilegeassemblytypeId;
    }
}

public sealed class InventoryPrivilegeAssemblyTypeUpdatedEvent : DomainEvent
{
    public InventoryPrivilegeAssemblyTypeId InventoryPrivilegeAssemblyTypeId { get; }

    public InventoryPrivilegeAssemblyTypeUpdatedEvent(InventoryPrivilegeAssemblyTypeId inventoryprivilegeassemblytypeId)
    {
        InventoryPrivilegeAssemblyTypeId = inventoryprivilegeassemblytypeId;
    }
}

public sealed class InventoryPrivilegeAssemblyTypeDeletedEvent : DomainEvent
{
    public InventoryPrivilegeAssemblyTypeId InventoryPrivilegeAssemblyTypeId { get; }

    public InventoryPrivilegeAssemblyTypeDeletedEvent(InventoryPrivilegeAssemblyTypeId inventoryprivilegeassemblytypeId)
    {
        InventoryPrivilegeAssemblyTypeId = inventoryprivilegeassemblytypeId;
    }
}
}
