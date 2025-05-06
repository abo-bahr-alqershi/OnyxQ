using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to ReturnSalesType entity
/// </summary>
public sealed class ReturnSalesTypeCreatedEvent : DomainEvent
{
    public ReturnSalesTypeId ReturnSalesTypeId { get; }

    public ReturnSalesTypeCreatedEvent(ReturnSalesTypeId returnsalestypeId)
    {
        ReturnSalesTypeId = returnsalestypeId;
    }
}

public sealed class ReturnSalesTypeUpdatedEvent : DomainEvent
{
    public ReturnSalesTypeId ReturnSalesTypeId { get; }

    public ReturnSalesTypeUpdatedEvent(ReturnSalesTypeId returnsalestypeId)
    {
        ReturnSalesTypeId = returnsalestypeId;
    }
}

public sealed class ReturnSalesTypeDeletedEvent : DomainEvent
{
    public ReturnSalesTypeId ReturnSalesTypeId { get; }

    public ReturnSalesTypeDeletedEvent(ReturnSalesTypeId returnsalestypeId)
    {
        ReturnSalesTypeId = returnsalestypeId;
    }
}
}
