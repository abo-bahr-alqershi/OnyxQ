using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to ItemActivityPrivilege entity
/// </summary>
public sealed class ItemActivityPrivilegeCreatedEvent : DomainEvent
{
    public ItemActivityPrivilegeId ItemActivityPrivilegeId { get; }

    public ItemActivityPrivilegeCreatedEvent(ItemActivityPrivilegeId itemactivityprivilegeId)
    {
        ItemActivityPrivilegeId = itemactivityprivilegeId;
    }
}

public sealed class ItemActivityPrivilegeUpdatedEvent : DomainEvent
{
    public ItemActivityPrivilegeId ItemActivityPrivilegeId { get; }

    public ItemActivityPrivilegeUpdatedEvent(ItemActivityPrivilegeId itemactivityprivilegeId)
    {
        ItemActivityPrivilegeId = itemactivityprivilegeId;
    }
}

public sealed class ItemActivityPrivilegeDeletedEvent : DomainEvent
{
    public ItemActivityPrivilegeId ItemActivityPrivilegeId { get; }

    public ItemActivityPrivilegeDeletedEvent(ItemActivityPrivilegeId itemactivityprivilegeId)
    {
        ItemActivityPrivilegeId = itemactivityprivilegeId;
    }
}
}
