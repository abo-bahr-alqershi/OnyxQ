using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeInventoryType entity
/// </summary>
public sealed class PrivilegeInventoryTypeCreatedEvent : DomainEvent
{
    public PrivilegeInventoryTypeId PrivilegeInventoryTypeId { get; }

    public PrivilegeInventoryTypeCreatedEvent(PrivilegeInventoryTypeId privilegeinventorytypeId)
    {
        PrivilegeInventoryTypeId = privilegeinventorytypeId;
    }
}

public sealed class PrivilegeInventoryTypeUpdatedEvent : DomainEvent
{
    public PrivilegeInventoryTypeId PrivilegeInventoryTypeId { get; }

    public PrivilegeInventoryTypeUpdatedEvent(PrivilegeInventoryTypeId privilegeinventorytypeId)
    {
        PrivilegeInventoryTypeId = privilegeinventorytypeId;
    }
}

public sealed class PrivilegeInventoryTypeDeletedEvent : DomainEvent
{
    public PrivilegeInventoryTypeId PrivilegeInventoryTypeId { get; }

    public PrivilegeInventoryTypeDeletedEvent(PrivilegeInventoryTypeId privilegeinventorytypeId)
    {
        PrivilegeInventoryTypeId = privilegeinventorytypeId;
    }
}
}
