using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeActivity entity
/// </summary>
public sealed class PrivilegeActivityCreatedEvent : DomainEvent
{
    public PrivilegeActivityId PrivilegeActivityId { get; }

    public PrivilegeActivityCreatedEvent(PrivilegeActivityId privilegeactivityId)
    {
        PrivilegeActivityId = privilegeactivityId;
    }
}

public sealed class PrivilegeActivityUpdatedEvent : DomainEvent
{
    public PrivilegeActivityId PrivilegeActivityId { get; }

    public PrivilegeActivityUpdatedEvent(PrivilegeActivityId privilegeactivityId)
    {
        PrivilegeActivityId = privilegeactivityId;
    }
}

public sealed class PrivilegeActivityDeletedEvent : DomainEvent
{
    public PrivilegeActivityId PrivilegeActivityId { get; }

    public PrivilegeActivityDeletedEvent(PrivilegeActivityId privilegeactivityId)
    {
        PrivilegeActivityId = privilegeactivityId;
    }
}
}
