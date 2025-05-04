using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerSigns entity
/// </summary>
public sealed class CustomerSignsCreatedEvent : DomainEvent
{
    public CustomerSignsId CustomerSignsId { get; }

    public CustomerSignsCreatedEvent(CustomerSignsId customersignsId)
    {
        CustomerSignsId = customersignsId;
    }
}

public sealed class CustomerSignsUpdatedEvent : DomainEvent
{
    public CustomerSignsId CustomerSignsId { get; }

    public CustomerSignsUpdatedEvent(CustomerSignsId customersignsId)
    {
        CustomerSignsId = customersignsId;
    }
}

public sealed class CustomerSignsDeletedEvent : DomainEvent
{
    public CustomerSignsId CustomerSignsId { get; }

    public CustomerSignsDeletedEvent(CustomerSignsId customersignsId)
    {
        CustomerSignsId = customersignsId;
    }
}
}
