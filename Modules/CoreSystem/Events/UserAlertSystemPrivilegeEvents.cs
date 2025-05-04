using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to UserAlertSystemPrivilege entity
/// </summary>
public sealed class UserAlertSystemPrivilegeCreatedEvent : DomainEvent
{
    public UserAlertSystemPrivilegeId UserAlertSystemPrivilegeId { get; }

    public UserAlertSystemPrivilegeCreatedEvent(UserAlertSystemPrivilegeId useralertsystemprivilegeId)
    {
        UserAlertSystemPrivilegeId = useralertsystemprivilegeId;
    }
}

public sealed class UserAlertSystemPrivilegeUpdatedEvent : DomainEvent
{
    public UserAlertSystemPrivilegeId UserAlertSystemPrivilegeId { get; }

    public UserAlertSystemPrivilegeUpdatedEvent(UserAlertSystemPrivilegeId useralertsystemprivilegeId)
    {
        UserAlertSystemPrivilegeId = useralertsystemprivilegeId;
    }
}

public sealed class UserAlertSystemPrivilegeDeletedEvent : DomainEvent
{
    public UserAlertSystemPrivilegeId UserAlertSystemPrivilegeId { get; }

    public UserAlertSystemPrivilegeDeletedEvent(UserAlertSystemPrivilegeId useralertsystemprivilegeId)
    {
        UserAlertSystemPrivilegeId = useralertsystemprivilegeId;
    }
}
}
