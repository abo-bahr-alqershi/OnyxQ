using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to GeneralPermission entity
/// </summary>
public sealed class GeneralPermissionCreatedEvent : DomainEvent
{
    public GeneralPermissionId GeneralPermissionId { get; }

    public GeneralPermissionCreatedEvent(GeneralPermissionId generalpermissionId)
    {
        GeneralPermissionId = generalpermissionId;
    }
}

public sealed class GeneralPermissionUpdatedEvent : DomainEvent
{
    public GeneralPermissionId GeneralPermissionId { get; }

    public GeneralPermissionUpdatedEvent(GeneralPermissionId generalpermissionId)
    {
        GeneralPermissionId = generalpermissionId;
    }
}

public sealed class GeneralPermissionDeletedEvent : DomainEvent
{
    public GeneralPermissionId GeneralPermissionId { get; }

    public GeneralPermissionDeletedEvent(GeneralPermissionId generalpermissionId)
    {
        GeneralPermissionId = generalpermissionId;
    }
}
}
