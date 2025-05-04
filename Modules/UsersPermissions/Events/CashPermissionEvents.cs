using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to CashPermission entity
/// </summary>
public sealed class CashPermissionCreatedEvent : DomainEvent
{
    public CashPermissionId CashPermissionId { get; }

    public CashPermissionCreatedEvent(CashPermissionId cashpermissionId)
    {
        CashPermissionId = cashpermissionId;
    }
}

public sealed class CashPermissionUpdatedEvent : DomainEvent
{
    public CashPermissionId CashPermissionId { get; }

    public CashPermissionUpdatedEvent(CashPermissionId cashpermissionId)
    {
        CashPermissionId = cashpermissionId;
    }
}

public sealed class CashPermissionDeletedEvent : DomainEvent
{
    public CashPermissionId CashPermissionId { get; }

    public CashPermissionDeletedEvent(CashPermissionId cashpermissionId)
    {
        CashPermissionId = cashpermissionId;
    }
}
}
