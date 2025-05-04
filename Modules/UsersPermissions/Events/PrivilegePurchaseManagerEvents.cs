using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegePurchaseManager entity
/// </summary>
public sealed class PrivilegePurchaseManagerCreatedEvent : DomainEvent
{
    public PrivilegePurchaseManagerId PrivilegePurchaseManagerId { get; }

    public PrivilegePurchaseManagerCreatedEvent(PrivilegePurchaseManagerId privilegepurchasemanagerId)
    {
        PrivilegePurchaseManagerId = privilegepurchasemanagerId;
    }
}

public sealed class PrivilegePurchaseManagerUpdatedEvent : DomainEvent
{
    public PrivilegePurchaseManagerId PrivilegePurchaseManagerId { get; }

    public PrivilegePurchaseManagerUpdatedEvent(PrivilegePurchaseManagerId privilegepurchasemanagerId)
    {
        PrivilegePurchaseManagerId = privilegepurchasemanagerId;
    }
}

public sealed class PrivilegePurchaseManagerDeletedEvent : DomainEvent
{
    public PrivilegePurchaseManagerId PrivilegePurchaseManagerId { get; }

    public PrivilegePurchaseManagerDeletedEvent(PrivilegePurchaseManagerId privilegepurchasemanagerId)
    {
        PrivilegePurchaseManagerId = privilegepurchasemanagerId;
    }
}
}
