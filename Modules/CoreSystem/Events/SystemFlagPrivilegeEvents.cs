using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SystemFlagPrivilege entity
/// </summary>
public sealed class SystemFlagPrivilegeCreatedEvent : DomainEvent
{
    public SystemFlagPrivilegeId SystemFlagPrivilegeId { get; }

    public SystemFlagPrivilegeCreatedEvent(SystemFlagPrivilegeId systemflagprivilegeId)
    {
        SystemFlagPrivilegeId = systemflagprivilegeId;
    }
}

public sealed class SystemFlagPrivilegeUpdatedEvent : DomainEvent
{
    public SystemFlagPrivilegeId SystemFlagPrivilegeId { get; }

    public SystemFlagPrivilegeUpdatedEvent(SystemFlagPrivilegeId systemflagprivilegeId)
    {
        SystemFlagPrivilegeId = systemflagprivilegeId;
    }
}

public sealed class SystemFlagPrivilegeDeletedEvent : DomainEvent
{
    public SystemFlagPrivilegeId SystemFlagPrivilegeId { get; }

    public SystemFlagPrivilegeDeletedEvent(SystemFlagPrivilegeId systemflagprivilegeId)
    {
        SystemFlagPrivilegeId = systemflagprivilegeId;
    }
}
}
