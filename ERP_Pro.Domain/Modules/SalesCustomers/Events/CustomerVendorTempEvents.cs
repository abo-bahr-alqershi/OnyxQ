using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerVendorTemp entity
/// </summary>
public sealed class CustomerVendorTempCreatedEvent : DomainEvent
{
    public CustomerVendorTempId CustomerVendorTempId { get; }

    public CustomerVendorTempCreatedEvent(CustomerVendorTempId customervendortempId)
    {
        CustomerVendorTempId = customervendortempId;
    }
}

public sealed class CustomerVendorTempUpdatedEvent : DomainEvent
{
    public CustomerVendorTempId CustomerVendorTempId { get; }

    public CustomerVendorTempUpdatedEvent(CustomerVendorTempId customervendortempId)
    {
        CustomerVendorTempId = customervendortempId;
    }
}

public sealed class CustomerVendorTempDeletedEvent : DomainEvent
{
    public CustomerVendorTempId CustomerVendorTempId { get; }

    public CustomerVendorTempDeletedEvent(CustomerVendorTempId customervendortempId)
    {
        CustomerVendorTempId = customervendortempId;
    }
}
}
