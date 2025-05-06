using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to IncomeTypePermission entity
/// </summary>
public sealed class IncomeTypePermissionCreatedEvent : DomainEvent
{
    public IncomeTypePermissionId IncomeTypePermissionId { get; }

    public IncomeTypePermissionCreatedEvent(IncomeTypePermissionId incometypepermissionId)
    {
        IncomeTypePermissionId = incometypepermissionId;
    }
}

public sealed class IncomeTypePermissionUpdatedEvent : DomainEvent
{
    public IncomeTypePermissionId IncomeTypePermissionId { get; }

    public IncomeTypePermissionUpdatedEvent(IncomeTypePermissionId incometypepermissionId)
    {
        IncomeTypePermissionId = incometypepermissionId;
    }
}

public sealed class IncomeTypePermissionDeletedEvent : DomainEvent
{
    public IncomeTypePermissionId IncomeTypePermissionId { get; }

    public IncomeTypePermissionDeletedEvent(IncomeTypePermissionId incometypepermissionId)
    {
        IncomeTypePermissionId = incometypepermissionId;
    }
}
}
