using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegePrice entity
/// </summary>
public sealed class PrivilegePriceCreatedEvent : DomainEvent
{
    public PrivilegePriceId PrivilegePriceId { get; }

    public PrivilegePriceCreatedEvent(PrivilegePriceId privilegepriceId)
    {
        PrivilegePriceId = privilegepriceId;
    }
}

public sealed class PrivilegePriceUpdatedEvent : DomainEvent
{
    public PrivilegePriceId PrivilegePriceId { get; }

    public PrivilegePriceUpdatedEvent(PrivilegePriceId privilegepriceId)
    {
        PrivilegePriceId = privilegepriceId;
    }
}

public sealed class PrivilegePriceDeletedEvent : DomainEvent
{
    public PrivilegePriceId PrivilegePriceId { get; }

    public PrivilegePriceDeletedEvent(PrivilegePriceId privilegepriceId)
    {
        PrivilegePriceId = privilegepriceId;
    }
}
}
