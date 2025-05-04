using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesFreeQuantityHistory entity
/// </summary>
public sealed class SalesFreeQuantityHistoryCreatedEvent : DomainEvent
{
    public SalesFreeQuantityHistoryId SalesFreeQuantityHistoryId { get; }

    public SalesFreeQuantityHistoryCreatedEvent(SalesFreeQuantityHistoryId salesfreequantityhistoryId)
    {
        SalesFreeQuantityHistoryId = salesfreequantityhistoryId;
    }
}

public sealed class SalesFreeQuantityHistoryUpdatedEvent : DomainEvent
{
    public SalesFreeQuantityHistoryId SalesFreeQuantityHistoryId { get; }

    public SalesFreeQuantityHistoryUpdatedEvent(SalesFreeQuantityHistoryId salesfreequantityhistoryId)
    {
        SalesFreeQuantityHistoryId = salesfreequantityhistoryId;
    }
}

public sealed class SalesFreeQuantityHistoryDeletedEvent : DomainEvent
{
    public SalesFreeQuantityHistoryId SalesFreeQuantityHistoryId { get; }

    public SalesFreeQuantityHistoryDeletedEvent(SalesFreeQuantityHistoryId salesfreequantityhistoryId)
    {
        SalesFreeQuantityHistoryId = salesfreequantityhistoryId;
    }
}
}
