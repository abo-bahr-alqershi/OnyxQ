using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemSalesAge entity
/// </summary>
public sealed class ItemSalesAgeCreatedEvent : DomainEvent
{
    public ItemSalesAgeId ItemSalesAgeId { get; }

    public ItemSalesAgeCreatedEvent(ItemSalesAgeId itemsalesageId)
    {
        ItemSalesAgeId = itemsalesageId;
    }
}

public sealed class ItemSalesAgeUpdatedEvent : DomainEvent
{
    public ItemSalesAgeId ItemSalesAgeId { get; }

    public ItemSalesAgeUpdatedEvent(ItemSalesAgeId itemsalesageId)
    {
        ItemSalesAgeId = itemsalesageId;
    }
}

public sealed class ItemSalesAgeDeletedEvent : DomainEvent
{
    public ItemSalesAgeId ItemSalesAgeId { get; }

    public ItemSalesAgeDeletedEvent(ItemSalesAgeId itemsalesageId)
    {
        ItemSalesAgeId = itemsalesageId;
    }
}
}
