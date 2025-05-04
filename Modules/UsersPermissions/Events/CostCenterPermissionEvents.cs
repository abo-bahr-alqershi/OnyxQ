using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to CostCenterPermission entity
/// </summary>
public sealed class CostCenterPermissionCreatedEvent : DomainEvent
{
    public CostCenterPermissionId CostCenterPermissionId { get; }

    public CostCenterPermissionCreatedEvent(CostCenterPermissionId costcenterpermissionId)
    {
        CostCenterPermissionId = costcenterpermissionId;
    }
}

public sealed class CostCenterPermissionUpdatedEvent : DomainEvent
{
    public CostCenterPermissionId CostCenterPermissionId { get; }

    public CostCenterPermissionUpdatedEvent(CostCenterPermissionId costcenterpermissionId)
    {
        CostCenterPermissionId = costcenterpermissionId;
    }
}

public sealed class CostCenterPermissionDeletedEvent : DomainEvent
{
    public CostCenterPermissionId CostCenterPermissionId { get; }

    public CostCenterPermissionDeletedEvent(CostCenterPermissionId costcenterpermissionId)
    {
        CostCenterPermissionId = costcenterpermissionId;
    }
}
}
