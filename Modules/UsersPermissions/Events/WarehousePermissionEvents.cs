using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to WarehousePermission entity
/// </summary>
public sealed class WarehousePermissionCreatedEvent : DomainEvent
{
    public WarehousePermissionId WarehousePermissionId { get; }

    public WarehousePermissionCreatedEvent(WarehousePermissionId warehousepermissionId)
    {
        WarehousePermissionId = warehousepermissionId;
    }
}

public sealed class WarehousePermissionUpdatedEvent : DomainEvent
{
    public WarehousePermissionId WarehousePermissionId { get; }

    public WarehousePermissionUpdatedEvent(WarehousePermissionId warehousepermissionId)
    {
        WarehousePermissionId = warehousepermissionId;
    }
}

public sealed class WarehousePermissionDeletedEvent : DomainEvent
{
    public WarehousePermissionId WarehousePermissionId { get; }

    public WarehousePermissionDeletedEvent(WarehousePermissionId warehousepermissionId)
    {
        WarehousePermissionId = warehousepermissionId;
    }
}
}
