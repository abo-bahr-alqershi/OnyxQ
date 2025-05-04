using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerItemLimitSale entity
/// </summary>
public sealed class CustomerItemLimitSaleCreatedEvent : DomainEvent
{
    public CustomerItemLimitSaleId CustomerItemLimitSaleId { get; }

    public CustomerItemLimitSaleCreatedEvent(CustomerItemLimitSaleId customeritemlimitsaleId)
    {
        CustomerItemLimitSaleId = customeritemlimitsaleId;
    }
}

public sealed class CustomerItemLimitSaleUpdatedEvent : DomainEvent
{
    public CustomerItemLimitSaleId CustomerItemLimitSaleId { get; }

    public CustomerItemLimitSaleUpdatedEvent(CustomerItemLimitSaleId customeritemlimitsaleId)
    {
        CustomerItemLimitSaleId = customeritemlimitsaleId;
    }
}

public sealed class CustomerItemLimitSaleDeletedEvent : DomainEvent
{
    public CustomerItemLimitSaleId CustomerItemLimitSaleId { get; }

    public CustomerItemLimitSaleDeletedEvent(CustomerItemLimitSaleId customeritemlimitsaleId)
    {
        CustomerItemLimitSaleId = customeritemlimitsaleId;
    }
}
}
