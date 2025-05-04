using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerClassType entity
/// </summary>
public sealed class CustomerClassTypeCreatedEvent : DomainEvent
{
    public CustomerClassTypeId CustomerClassTypeId { get; }

    public CustomerClassTypeCreatedEvent(CustomerClassTypeId customerclasstypeId)
    {
        CustomerClassTypeId = customerclasstypeId;
    }
}

public sealed class CustomerClassTypeUpdatedEvent : DomainEvent
{
    public CustomerClassTypeId CustomerClassTypeId { get; }

    public CustomerClassTypeUpdatedEvent(CustomerClassTypeId customerclasstypeId)
    {
        CustomerClassTypeId = customerclasstypeId;
    }
}

public sealed class CustomerClassTypeDeletedEvent : DomainEvent
{
    public CustomerClassTypeId CustomerClassTypeId { get; }

    public CustomerClassTypeDeletedEvent(CustomerClassTypeId customerclasstypeId)
    {
        CustomerClassTypeId = customerclasstypeId;
    }
}
}
