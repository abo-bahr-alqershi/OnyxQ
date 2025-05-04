using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeVendor entity
/// </summary>
public sealed class PrivilegeVendorCreatedEvent : DomainEvent
{
    public PrivilegeVendorId PrivilegeVendorId { get; }

    public PrivilegeVendorCreatedEvent(PrivilegeVendorId privilegevendorId)
    {
        PrivilegeVendorId = privilegevendorId;
    }
}

public sealed class PrivilegeVendorUpdatedEvent : DomainEvent
{
    public PrivilegeVendorId PrivilegeVendorId { get; }

    public PrivilegeVendorUpdatedEvent(PrivilegeVendorId privilegevendorId)
    {
        PrivilegeVendorId = privilegevendorId;
    }
}

public sealed class PrivilegeVendorDeletedEvent : DomainEvent
{
    public PrivilegeVendorId PrivilegeVendorId { get; }

    public PrivilegeVendorDeletedEvent(PrivilegeVendorId privilegevendorId)
    {
        PrivilegeVendorId = privilegevendorId;
    }
}
}
