using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryBatchNumberMethodMaster entity
/// </summary>
public sealed class InventoryBatchNumberMethodMasterCreatedEvent : DomainEvent
{
    public InventoryBatchNumberMethodMasterId InventoryBatchNumberMethodMasterId { get; }

    public InventoryBatchNumberMethodMasterCreatedEvent(InventoryBatchNumberMethodMasterId inventorybatchnumbermethodmasterId)
    {
        InventoryBatchNumberMethodMasterId = inventorybatchnumbermethodmasterId;
    }
}

public sealed class InventoryBatchNumberMethodMasterUpdatedEvent : DomainEvent
{
    public InventoryBatchNumberMethodMasterId InventoryBatchNumberMethodMasterId { get; }

    public InventoryBatchNumberMethodMasterUpdatedEvent(InventoryBatchNumberMethodMasterId inventorybatchnumbermethodmasterId)
    {
        InventoryBatchNumberMethodMasterId = inventorybatchnumbermethodmasterId;
    }
}

public sealed class InventoryBatchNumberMethodMasterDeletedEvent : DomainEvent
{
    public InventoryBatchNumberMethodMasterId InventoryBatchNumberMethodMasterId { get; }

    public InventoryBatchNumberMethodMasterDeletedEvent(InventoryBatchNumberMethodMasterId inventorybatchnumbermethodmasterId)
    {
        InventoryBatchNumberMethodMasterId = inventorybatchnumbermethodmasterId;
    }
}
}
