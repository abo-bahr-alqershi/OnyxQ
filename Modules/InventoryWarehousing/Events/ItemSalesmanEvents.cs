using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemSalesman entity
/// </summary>
public sealed class ItemSalesmanCreatedEvent : DomainEvent
{
    public ItemSalesmanId ItemSalesmanId { get; }

    public ItemSalesmanCreatedEvent(ItemSalesmanId itemsalesmanId)
    {
        ItemSalesmanId = itemsalesmanId;
    }
}

public sealed class ItemSalesmanUpdatedEvent : DomainEvent
{
    public ItemSalesmanId ItemSalesmanId { get; }

    public ItemSalesmanUpdatedEvent(ItemSalesmanId itemsalesmanId)
    {
        ItemSalesmanId = itemsalesmanId;
    }
}

public sealed class ItemSalesmanDeletedEvent : DomainEvent
{
    public ItemSalesmanId ItemSalesmanId { get; }

    public ItemSalesmanDeletedEvent(ItemSalesmanId itemsalesmanId)
    {
        ItemSalesmanId = itemsalesmanId;
    }
}
}
