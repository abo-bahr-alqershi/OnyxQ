using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to FixedPermission entity
/// </summary>
public sealed class FixedPermissionCreatedEvent : DomainEvent
{
    public FixedPermissionId FixedPermissionId { get; }

    public FixedPermissionCreatedEvent(FixedPermissionId fixedpermissionId)
    {
        FixedPermissionId = fixedpermissionId;
    }
}

public sealed class FixedPermissionUpdatedEvent : DomainEvent
{
    public FixedPermissionId FixedPermissionId { get; }

    public FixedPermissionUpdatedEvent(FixedPermissionId fixedpermissionId)
    {
        FixedPermissionId = fixedpermissionId;
    }
}

public sealed class FixedPermissionDeletedEvent : DomainEvent
{
    public FixedPermissionId FixedPermissionId { get; }

    public FixedPermissionDeletedEvent(FixedPermissionId fixedpermissionId)
    {
        FixedPermissionId = fixedpermissionId;
    }
}
}
