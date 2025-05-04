using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesDiscountHistory entity
/// </summary>
public sealed class SalesDiscountHistoryCreatedEvent : DomainEvent
{
    public SalesDiscountHistoryId SalesDiscountHistoryId { get; }

    public SalesDiscountHistoryCreatedEvent(SalesDiscountHistoryId salesdiscounthistoryId)
    {
        SalesDiscountHistoryId = salesdiscounthistoryId;
    }
}

public sealed class SalesDiscountHistoryUpdatedEvent : DomainEvent
{
    public SalesDiscountHistoryId SalesDiscountHistoryId { get; }

    public SalesDiscountHistoryUpdatedEvent(SalesDiscountHistoryId salesdiscounthistoryId)
    {
        SalesDiscountHistoryId = salesdiscounthistoryId;
    }
}

public sealed class SalesDiscountHistoryDeletedEvent : DomainEvent
{
    public SalesDiscountHistoryId SalesDiscountHistoryId { get; }

    public SalesDiscountHistoryDeletedEvent(SalesDiscountHistoryId salesdiscounthistoryId)
    {
        SalesDiscountHistoryId = salesdiscounthistoryId;
    }
}
}
