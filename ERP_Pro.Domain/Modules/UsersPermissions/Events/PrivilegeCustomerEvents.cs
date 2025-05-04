using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeCustomer entity
/// </summary>
public sealed class PrivilegeCustomerCreatedEvent : DomainEvent
{
    public PrivilegeCustomerId PrivilegeCustomerId { get; }

    public PrivilegeCustomerCreatedEvent(PrivilegeCustomerId privilegecustomerId)
    {
        PrivilegeCustomerId = privilegecustomerId;
    }
}

public sealed class PrivilegeCustomerUpdatedEvent : DomainEvent
{
    public PrivilegeCustomerId PrivilegeCustomerId { get; }

    public PrivilegeCustomerUpdatedEvent(PrivilegeCustomerId privilegecustomerId)
    {
        PrivilegeCustomerId = privilegecustomerId;
    }
}

public sealed class PrivilegeCustomerDeletedEvent : DomainEvent
{
    public PrivilegeCustomerId PrivilegeCustomerId { get; }

    public PrivilegeCustomerDeletedEvent(PrivilegeCustomerId privilegecustomerId)
    {
        PrivilegeCustomerId = privilegecustomerId;
    }
}
}
