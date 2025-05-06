using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to TransferTypePermission entity
/// </summary>
public sealed class TransferTypePermissionCreatedEvent : DomainEvent
{
    public TransferTypePermissionId TransferTypePermissionId { get; }

    public TransferTypePermissionCreatedEvent(TransferTypePermissionId transfertypepermissionId)
    {
        TransferTypePermissionId = transfertypepermissionId;
    }
}

public sealed class TransferTypePermissionUpdatedEvent : DomainEvent
{
    public TransferTypePermissionId TransferTypePermissionId { get; }

    public TransferTypePermissionUpdatedEvent(TransferTypePermissionId transfertypepermissionId)
    {
        TransferTypePermissionId = transfertypepermissionId;
    }
}

public sealed class TransferTypePermissionDeletedEvent : DomainEvent
{
    public TransferTypePermissionId TransferTypePermissionId { get; }

    public TransferTypePermissionDeletedEvent(TransferTypePermissionId transfertypepermissionId)
    {
        TransferTypePermissionId = transfertypepermissionId;
    }
}
}
