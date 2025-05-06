using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to RequestTypePermission entity
/// </summary>
public sealed class RequestTypePermissionCreatedEvent : DomainEvent
{
    public RequestTypePermissionId RequestTypePermissionId { get; }

    public RequestTypePermissionCreatedEvent(RequestTypePermissionId requesttypepermissionId)
    {
        RequestTypePermissionId = requesttypepermissionId;
    }
}

public sealed class RequestTypePermissionUpdatedEvent : DomainEvent
{
    public RequestTypePermissionId RequestTypePermissionId { get; }

    public RequestTypePermissionUpdatedEvent(RequestTypePermissionId requesttypepermissionId)
    {
        RequestTypePermissionId = requesttypepermissionId;
    }
}

public sealed class RequestTypePermissionDeletedEvent : DomainEvent
{
    public RequestTypePermissionId RequestTypePermissionId { get; }

    public RequestTypePermissionDeletedEvent(RequestTypePermissionId requesttypepermissionId)
    {
        RequestTypePermissionId = requesttypepermissionId;
    }
}
}
