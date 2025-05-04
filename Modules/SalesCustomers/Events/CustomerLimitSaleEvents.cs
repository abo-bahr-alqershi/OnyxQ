using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerLimitSale entity
/// </summary>
public sealed class CustomerLimitSaleCreatedEvent : DomainEvent
{
    public CustomerLimitSaleId CustomerLimitSaleId { get; }

    public CustomerLimitSaleCreatedEvent(CustomerLimitSaleId customerlimitsaleId)
    {
        CustomerLimitSaleId = customerlimitsaleId;
    }
}

public sealed class CustomerLimitSaleUpdatedEvent : DomainEvent
{
    public CustomerLimitSaleId CustomerLimitSaleId { get; }

    public CustomerLimitSaleUpdatedEvent(CustomerLimitSaleId customerlimitsaleId)
    {
        CustomerLimitSaleId = customerlimitsaleId;
    }
}

public sealed class CustomerLimitSaleDeletedEvent : DomainEvent
{
    public CustomerLimitSaleId CustomerLimitSaleId { get; }

    public CustomerLimitSaleDeletedEvent(CustomerLimitSaleId customerlimitsaleId)
    {
        CustomerLimitSaleId = customerlimitsaleId;
    }
}
}
