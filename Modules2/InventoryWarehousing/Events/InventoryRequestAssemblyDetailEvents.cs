using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryRequestAssemblyDetail entity
/// </summary>
public sealed class InventoryRequestAssemblyDetailCreatedEvent : DomainEvent
{
    public InventoryRequestAssemblyDetailId InventoryRequestAssemblyDetailId { get; }

    public InventoryRequestAssemblyDetailCreatedEvent(InventoryRequestAssemblyDetailId inventoryrequestassemblydetailId)
    {
        InventoryRequestAssemblyDetailId = inventoryrequestassemblydetailId;
    }
}

public sealed class InventoryRequestAssemblyDetailUpdatedEvent : DomainEvent
{
    public InventoryRequestAssemblyDetailId InventoryRequestAssemblyDetailId { get; }

    public InventoryRequestAssemblyDetailUpdatedEvent(InventoryRequestAssemblyDetailId inventoryrequestassemblydetailId)
    {
        InventoryRequestAssemblyDetailId = inventoryrequestassemblydetailId;
    }
}

public sealed class InventoryRequestAssemblyDetailDeletedEvent : DomainEvent
{
    public InventoryRequestAssemblyDetailId InventoryRequestAssemblyDetailId { get; }

    public InventoryRequestAssemblyDetailDeletedEvent(InventoryRequestAssemblyDetailId inventoryrequestassemblydetailId)
    {
        InventoryRequestAssemblyDetailId = inventoryrequestassemblydetailId;
    }
}
}
