using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCurrency entity
/// </summary>
public sealed class CustomerCurrencyCreatedEvent : DomainEvent
{
    public CustomerCurrencyId CustomerCurrencyId { get; }

    public CustomerCurrencyCreatedEvent(CustomerCurrencyId customercurrencyId)
    {
        CustomerCurrencyId = customercurrencyId;
    }
}

public sealed class CustomerCurrencyUpdatedEvent : DomainEvent
{
    public CustomerCurrencyId CustomerCurrencyId { get; }

    public CustomerCurrencyUpdatedEvent(CustomerCurrencyId customercurrencyId)
    {
        CustomerCurrencyId = customercurrencyId;
    }
}

public sealed class CustomerCurrencyDeletedEvent : DomainEvent
{
    public CustomerCurrencyId CustomerCurrencyId { get; }

    public CustomerCurrencyDeletedEvent(CustomerCurrencyId customercurrencyId)
    {
        CustomerCurrencyId = customercurrencyId;
    }
}
}
