using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to UserCopyAudit entity
/// </summary>
public sealed class UserCopyAuditCreatedEvent : DomainEvent
{
    public UserCopyAuditId UserCopyAuditId { get; }

    public UserCopyAuditCreatedEvent(UserCopyAuditId usercopyauditId)
    {
        UserCopyAuditId = usercopyauditId;
    }
}

public sealed class UserCopyAuditUpdatedEvent : DomainEvent
{
    public UserCopyAuditId UserCopyAuditId { get; }

    public UserCopyAuditUpdatedEvent(UserCopyAuditId usercopyauditId)
    {
        UserCopyAuditId = usercopyauditId;
    }
}

public sealed class UserCopyAuditDeletedEvent : DomainEvent
{
    public UserCopyAuditId UserCopyAuditId { get; }

    public UserCopyAuditDeletedEvent(UserCopyAuditId usercopyauditId)
    {
        UserCopyAuditId = usercopyauditId;
    }
}
}
