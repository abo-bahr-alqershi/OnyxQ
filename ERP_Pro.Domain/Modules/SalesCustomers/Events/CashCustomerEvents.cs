using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CashCustomer entity
/// </summary>
public sealed class CashCustomerCreatedEvent : DomainEvent
{
    public CashCustomerId CashCustomerId { get; }

    public CashCustomerCreatedEvent(CashCustomerId cashcustomerId)
    {
        CashCustomerId = cashcustomerId;
    }
}

public sealed class CashCustomerUpdatedEvent : DomainEvent
{
    public CashCustomerId CashCustomerId { get; }

    public CashCustomerUpdatedEvent(CashCustomerId cashcustomerId)
    {
        CashCustomerId = cashcustomerId;
    }
}

public sealed class CashCustomerDeletedEvent : DomainEvent
{
    public CashCustomerId CashCustomerId { get; }

    public CashCustomerDeletedEvent(CashCustomerId cashcustomerId)
    {
        CashCustomerId = cashcustomerId;
    }
}
}
