using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerTransactionGps entity
/// </summary>
public sealed class CustomerTransactionGpsCreatedEvent : DomainEvent
{
    public CustomerTransactionGpsId CustomerTransactionGpsId { get; }

    public CustomerTransactionGpsCreatedEvent(CustomerTransactionGpsId customertransactiongpsId)
    {
        CustomerTransactionGpsId = customertransactiongpsId;
    }
}

public sealed class CustomerTransactionGpsUpdatedEvent : DomainEvent
{
    public CustomerTransactionGpsId CustomerTransactionGpsId { get; }

    public CustomerTransactionGpsUpdatedEvent(CustomerTransactionGpsId customertransactiongpsId)
    {
        CustomerTransactionGpsId = customertransactiongpsId;
    }
}

public sealed class CustomerTransactionGpsDeletedEvent : DomainEvent
{
    public CustomerTransactionGpsId CustomerTransactionGpsId { get; }

    public CustomerTransactionGpsDeletedEvent(CustomerTransactionGpsId customertransactiongpsId)
    {
        CustomerTransactionGpsId = customertransactiongpsId;
    }
}
}
