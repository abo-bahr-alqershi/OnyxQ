using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryRequestAssemblyMaster entity
/// </summary>
public sealed class InventoryRequestAssemblyMasterCreatedEvent : DomainEvent
{
    public InventoryRequestAssemblyMasterId InventoryRequestAssemblyMasterId { get; }

    public InventoryRequestAssemblyMasterCreatedEvent(InventoryRequestAssemblyMasterId inventoryrequestassemblymasterId)
    {
        InventoryRequestAssemblyMasterId = inventoryrequestassemblymasterId;
    }
}

public sealed class InventoryRequestAssemblyMasterUpdatedEvent : DomainEvent
{
    public InventoryRequestAssemblyMasterId InventoryRequestAssemblyMasterId { get; }

    public InventoryRequestAssemblyMasterUpdatedEvent(InventoryRequestAssemblyMasterId inventoryrequestassemblymasterId)
    {
        InventoryRequestAssemblyMasterId = inventoryrequestassemblymasterId;
    }
}

public sealed class InventoryRequestAssemblyMasterDeletedEvent : DomainEvent
{
    public InventoryRequestAssemblyMasterId InventoryRequestAssemblyMasterId { get; }

    public InventoryRequestAssemblyMasterDeletedEvent(InventoryRequestAssemblyMasterId inventoryrequestassemblymasterId)
    {
        InventoryRequestAssemblyMasterId = inventoryrequestassemblymasterId;
    }
}
}
