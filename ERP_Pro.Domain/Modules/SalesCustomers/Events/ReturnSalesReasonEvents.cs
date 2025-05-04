using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnSalesReason entity
/// </summary>
public sealed class ReturnSalesReasonCreatedEvent : DomainEvent
{
    public ReturnSalesReasonId ReturnSalesReasonId { get; }

    public ReturnSalesReasonCreatedEvent(ReturnSalesReasonId returnsalesreasonId)
    {
        ReturnSalesReasonId = returnsalesreasonId;
    }
}

public sealed class ReturnSalesReasonUpdatedEvent : DomainEvent
{
    public ReturnSalesReasonId ReturnSalesReasonId { get; }

    public ReturnSalesReasonUpdatedEvent(ReturnSalesReasonId returnsalesreasonId)
    {
        ReturnSalesReasonId = returnsalesreasonId;
    }
}

public sealed class ReturnSalesReasonDeletedEvent : DomainEvent
{
    public ReturnSalesReasonId ReturnSalesReasonId { get; }

    public ReturnSalesReasonDeletedEvent(ReturnSalesReasonId returnsalesreasonId)
    {
        ReturnSalesReasonId = returnsalesreasonId;
    }
}
}
