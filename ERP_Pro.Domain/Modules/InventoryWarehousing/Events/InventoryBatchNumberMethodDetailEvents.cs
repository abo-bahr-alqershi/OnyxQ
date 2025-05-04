using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryBatchNumberMethodDetail entity
/// </summary>
public sealed class InventoryBatchNumberMethodDetailCreatedEvent : DomainEvent
{
    public InventoryBatchNumberMethodDetailId InventoryBatchNumberMethodDetailId { get; }

    public InventoryBatchNumberMethodDetailCreatedEvent(InventoryBatchNumberMethodDetailId inventorybatchnumbermethoddetailId)
    {
        InventoryBatchNumberMethodDetailId = inventorybatchnumbermethoddetailId;
    }
}

public sealed class InventoryBatchNumberMethodDetailUpdatedEvent : DomainEvent
{
    public InventoryBatchNumberMethodDetailId InventoryBatchNumberMethodDetailId { get; }

    public InventoryBatchNumberMethodDetailUpdatedEvent(InventoryBatchNumberMethodDetailId inventorybatchnumbermethoddetailId)
    {
        InventoryBatchNumberMethodDetailId = inventorybatchnumbermethoddetailId;
    }
}

public sealed class InventoryBatchNumberMethodDetailDeletedEvent : DomainEvent
{
    public InventoryBatchNumberMethodDetailId InventoryBatchNumberMethodDetailId { get; }

    public InventoryBatchNumberMethodDetailDeletedEvent(InventoryBatchNumberMethodDetailId inventorybatchnumbermethoddetailId)
    {
        InventoryBatchNumberMethodDetailId = inventorybatchnumbermethoddetailId;
    }
}
}
