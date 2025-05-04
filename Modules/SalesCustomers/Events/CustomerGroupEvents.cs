using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerGroup entity
/// </summary>
public sealed class CustomerGroupCreatedEvent : DomainEvent
{
    public CustomerGroupId CustomerGroupId { get; }

    public CustomerGroupCreatedEvent(CustomerGroupId customergroupId)
    {
        CustomerGroupId = customergroupId;
    }
}

public sealed class CustomerGroupUpdatedEvent : DomainEvent
{
    public CustomerGroupId CustomerGroupId { get; }

    public CustomerGroupUpdatedEvent(CustomerGroupId customergroupId)
    {
        CustomerGroupId = customergroupId;
    }
}

public sealed class CustomerGroupDeletedEvent : DomainEvent
{
    public CustomerGroupId CustomerGroupId { get; }

    public CustomerGroupDeletedEvent(CustomerGroupId customergroupId)
    {
        CustomerGroupId = customergroupId;
    }
}
}
