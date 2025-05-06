using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to UserTypePrivilege entity
/// </summary>
public sealed class UserTypePrivilegeCreatedEvent : DomainEvent
{
    public UserTypePrivilegeId UserTypePrivilegeId { get; }

    public UserTypePrivilegeCreatedEvent(UserTypePrivilegeId usertypeprivilegeId)
    {
        UserTypePrivilegeId = usertypeprivilegeId;
    }
}

public sealed class UserTypePrivilegeUpdatedEvent : DomainEvent
{
    public UserTypePrivilegeId UserTypePrivilegeId { get; }

    public UserTypePrivilegeUpdatedEvent(UserTypePrivilegeId usertypeprivilegeId)
    {
        UserTypePrivilegeId = usertypeprivilegeId;
    }
}

public sealed class UserTypePrivilegeDeletedEvent : DomainEvent
{
    public UserTypePrivilegeId UserTypePrivilegeId { get; }

    public UserTypePrivilegeDeletedEvent(UserTypePrivilegeId usertypeprivilegeId)
    {
        UserTypePrivilegeId = usertypeprivilegeId;
    }
}
}
