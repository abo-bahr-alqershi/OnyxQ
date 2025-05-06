using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemMaster entity
/// </summary>
public sealed class ItemMasterCreatedEvent : DomainEvent
{
    public ItemMasterId ItemMasterId { get; }

    public ItemMasterCreatedEvent(ItemMasterId itemmasterId)
    {
        ItemMasterId = itemmasterId;
    }
}

public sealed class ItemMasterUpdatedEvent : DomainEvent
{
    public ItemMasterId ItemMasterId { get; }

    public ItemMasterUpdatedEvent(ItemMasterId itemmasterId)
    {
        ItemMasterId = itemmasterId;
    }
}

public sealed class ItemMasterDeletedEvent : DomainEvent
{
    public ItemMasterId ItemMasterId { get; }

    public ItemMasterDeletedEvent(ItemMasterId itemmasterId)
    {
        ItemMasterId = itemmasterId;
    }
}
}
