using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserGroup entity
/// </summary>
public sealed class UserGroupCreatedEvent : DomainEvent
{
    public UserGroupId UserGroupId { get; }

    public UserGroupCreatedEvent(UserGroupId usergroupId)
    {
        UserGroupId = usergroupId;
    }
}

public sealed class UserGroupUpdatedEvent : DomainEvent
{
    public UserGroupId UserGroupId { get; }

    public UserGroupUpdatedEvent(UserGroupId usergroupId)
    {
        UserGroupId = usergroupId;
    }
}

public sealed class UserGroupDeletedEvent : DomainEvent
{
    public UserGroupId UserGroupId { get; }

    public UserGroupDeletedEvent(UserGroupId usergroupId)
    {
        UserGroupId = usergroupId;
    }
}
}
