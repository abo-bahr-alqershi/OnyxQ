using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerSalesman entity
/// </summary>
public sealed class CustomerSalesmanCreatedEvent : DomainEvent
{
    public CustomerSalesmanId CustomerSalesmanId { get; }

    public CustomerSalesmanCreatedEvent(CustomerSalesmanId customersalesmanId)
    {
        CustomerSalesmanId = customersalesmanId;
    }
}

public sealed class CustomerSalesmanUpdatedEvent : DomainEvent
{
    public CustomerSalesmanId CustomerSalesmanId { get; }

    public CustomerSalesmanUpdatedEvent(CustomerSalesmanId customersalesmanId)
    {
        CustomerSalesmanId = customersalesmanId;
    }
}

public sealed class CustomerSalesmanDeletedEvent : DomainEvent
{
    public CustomerSalesmanId CustomerSalesmanId { get; }

    public CustomerSalesmanDeletedEvent(CustomerSalesmanId customersalesmanId)
    {
        CustomerSalesmanId = customersalesmanId;
    }
}
}
