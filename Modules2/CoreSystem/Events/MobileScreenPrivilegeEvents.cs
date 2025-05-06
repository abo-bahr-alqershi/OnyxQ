using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to MobileScreenPrivilege entity
/// </summary>
public sealed class MobileScreenPrivilegeCreatedEvent : DomainEvent
{
    public MobileScreenPrivilegeId MobileScreenPrivilegeId { get; }

    public MobileScreenPrivilegeCreatedEvent(MobileScreenPrivilegeId mobilescreenprivilegeId)
    {
        MobileScreenPrivilegeId = mobilescreenprivilegeId;
    }
}

public sealed class MobileScreenPrivilegeUpdatedEvent : DomainEvent
{
    public MobileScreenPrivilegeId MobileScreenPrivilegeId { get; }

    public MobileScreenPrivilegeUpdatedEvent(MobileScreenPrivilegeId mobilescreenprivilegeId)
    {
        MobileScreenPrivilegeId = mobilescreenprivilegeId;
    }
}

public sealed class MobileScreenPrivilegeDeletedEvent : DomainEvent
{
    public MobileScreenPrivilegeId MobileScreenPrivilegeId { get; }

    public MobileScreenPrivilegeDeletedEvent(MobileScreenPrivilegeId mobilescreenprivilegeId)
    {
        MobileScreenPrivilegeId = mobilescreenprivilegeId;
    }
}
}
