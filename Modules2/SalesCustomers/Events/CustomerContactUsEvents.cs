using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerContactUs entity
/// </summary>
public sealed class CustomerContactUsCreatedEvent : DomainEvent
{
    public CustomerContactUsId CustomerContactUsId { get; }

    public CustomerContactUsCreatedEvent(CustomerContactUsId customercontactusId)
    {
        CustomerContactUsId = customercontactusId;
    }
}

public sealed class CustomerContactUsUpdatedEvent : DomainEvent
{
    public CustomerContactUsId CustomerContactUsId { get; }

    public CustomerContactUsUpdatedEvent(CustomerContactUsId customercontactusId)
    {
        CustomerContactUsId = customercontactusId;
    }
}

public sealed class CustomerContactUsDeletedEvent : DomainEvent
{
    public CustomerContactUsId CustomerContactUsId { get; }

    public CustomerContactUsDeletedEvent(CustomerContactUsId customercontactusId)
    {
        CustomerContactUsId = customercontactusId;
    }
}
}
