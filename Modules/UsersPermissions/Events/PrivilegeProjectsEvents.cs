using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeProjects entity
/// </summary>
public sealed class PrivilegeProjectsCreatedEvent : DomainEvent
{
    public PrivilegeProjectsId PrivilegeProjectsId { get; }

    public PrivilegeProjectsCreatedEvent(PrivilegeProjectsId privilegeprojectsId)
    {
        PrivilegeProjectsId = privilegeprojectsId;
    }
}

public sealed class PrivilegeProjectsUpdatedEvent : DomainEvent
{
    public PrivilegeProjectsId PrivilegeProjectsId { get; }

    public PrivilegeProjectsUpdatedEvent(PrivilegeProjectsId privilegeprojectsId)
    {
        PrivilegeProjectsId = privilegeprojectsId;
    }
}

public sealed class PrivilegeProjectsDeletedEvent : DomainEvent
{
    public PrivilegeProjectsId PrivilegeProjectsId { get; }

    public PrivilegeProjectsDeletedEvent(PrivilegeProjectsId privilegeprojectsId)
    {
        PrivilegeProjectsId = privilegeprojectsId;
    }
}
}
