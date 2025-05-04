using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to AccountPermission entity
/// </summary>
public sealed class AccountPermissionCreatedEvent : DomainEvent
{
    public AccountPermissionId AccountPermissionId { get; }

    public AccountPermissionCreatedEvent(AccountPermissionId accountpermissionId)
    {
        AccountPermissionId = accountpermissionId;
    }
}

public sealed class AccountPermissionUpdatedEvent : DomainEvent
{
    public AccountPermissionId AccountPermissionId { get; }

    public AccountPermissionUpdatedEvent(AccountPermissionId accountpermissionId)
    {
        AccountPermissionId = accountpermissionId;
    }
}

public sealed class AccountPermissionDeletedEvent : DomainEvent
{
    public AccountPermissionId AccountPermissionId { get; }

    public AccountPermissionDeletedEvent(AccountPermissionId accountpermissionId)
    {
        AccountPermissionId = accountpermissionId;
    }
}
}
