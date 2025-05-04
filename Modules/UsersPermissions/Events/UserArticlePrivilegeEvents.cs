using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserArticlePrivilege entity
/// </summary>
public sealed class UserArticlePrivilegeCreatedEvent : DomainEvent
{
    public UserArticlePrivilegeId UserArticlePrivilegeId { get; }

    public UserArticlePrivilegeCreatedEvent(UserArticlePrivilegeId userarticleprivilegeId)
    {
        UserArticlePrivilegeId = userarticleprivilegeId;
    }
}

public sealed class UserArticlePrivilegeUpdatedEvent : DomainEvent
{
    public UserArticlePrivilegeId UserArticlePrivilegeId { get; }

    public UserArticlePrivilegeUpdatedEvent(UserArticlePrivilegeId userarticleprivilegeId)
    {
        UserArticlePrivilegeId = userarticleprivilegeId;
    }
}

public sealed class UserArticlePrivilegeDeletedEvent : DomainEvent
{
    public UserArticlePrivilegeId UserArticlePrivilegeId { get; }

    public UserArticlePrivilegeDeletedEvent(UserArticlePrivilegeId userarticleprivilegeId)
    {
        UserArticlePrivilegeId = userarticleprivilegeId;
    }
}
}
