using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to OutgoingTypePermission entity
/// </summary>
public sealed class OutgoingTypePermissionCreatedEvent : DomainEvent
{
    public OutgoingTypePermissionId OutgoingTypePermissionId { get; }

    public OutgoingTypePermissionCreatedEvent(OutgoingTypePermissionId outgoingtypepermissionId)
    {
        OutgoingTypePermissionId = outgoingtypepermissionId;
    }
}

public sealed class OutgoingTypePermissionUpdatedEvent : DomainEvent
{
    public OutgoingTypePermissionId OutgoingTypePermissionId { get; }

    public OutgoingTypePermissionUpdatedEvent(OutgoingTypePermissionId outgoingtypepermissionId)
    {
        OutgoingTypePermissionId = outgoingtypepermissionId;
    }
}

public sealed class OutgoingTypePermissionDeletedEvent : DomainEvent
{
    public OutgoingTypePermissionId OutgoingTypePermissionId { get; }

    public OutgoingTypePermissionDeletedEvent(OutgoingTypePermissionId outgoingtypepermissionId)
    {
        OutgoingTypePermissionId = outgoingtypepermissionId;
    }
}
}
