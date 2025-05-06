using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCurrencyRequest entity
/// </summary>
public sealed class CustomerCurrencyRequestCreatedEvent : DomainEvent
{
    public CustomerCurrencyRequestId CustomerCurrencyRequestId { get; }

    public CustomerCurrencyRequestCreatedEvent(CustomerCurrencyRequestId customercurrencyrequestId)
    {
        CustomerCurrencyRequestId = customercurrencyrequestId;
    }
}

public sealed class CustomerCurrencyRequestUpdatedEvent : DomainEvent
{
    public CustomerCurrencyRequestId CustomerCurrencyRequestId { get; }

    public CustomerCurrencyRequestUpdatedEvent(CustomerCurrencyRequestId customercurrencyrequestId)
    {
        CustomerCurrencyRequestId = customercurrencyrequestId;
    }
}

public sealed class CustomerCurrencyRequestDeletedEvent : DomainEvent
{
    public CustomerCurrencyRequestId CustomerCurrencyRequestId { get; }

    public CustomerCurrencyRequestDeletedEvent(CustomerCurrencyRequestId customercurrencyrequestId)
    {
        CustomerCurrencyRequestId = customercurrencyrequestId;
    }
}
}
