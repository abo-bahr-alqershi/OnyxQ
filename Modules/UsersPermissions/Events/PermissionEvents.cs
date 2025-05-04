using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to Permission entity
/// </summary>
public sealed class PermissionCreatedEvent : DomainEvent
{
    public PermissionId PermissionId { get; }

    public PermissionCreatedEvent(PermissionId permissionId)
    {
        PermissionId = permissionId;
    }
}

public sealed class PermissionUpdatedEvent : DomainEvent
{
    public PermissionId PermissionId { get; }

    public PermissionUpdatedEvent(PermissionId permissionId)
    {
        PermissionId = permissionId;
    }
}

public sealed class PermissionDeletedEvent : DomainEvent
{
    public PermissionId PermissionId { get; }

    public PermissionDeletedEvent(PermissionId permissionId)
    {
        PermissionId = permissionId;
    }
}
}
