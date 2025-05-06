using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to ProjectGroup entity
/// </summary>
public sealed class ProjectGroupCreatedEvent : DomainEvent
{
    public ProjectGroupId ProjectGroupId { get; }

    public ProjectGroupCreatedEvent(ProjectGroupId projectgroupId)
    {
        ProjectGroupId = projectgroupId;
    }
}

public sealed class ProjectGroupUpdatedEvent : DomainEvent
{
    public ProjectGroupId ProjectGroupId { get; }

    public ProjectGroupUpdatedEvent(ProjectGroupId projectgroupId)
    {
        ProjectGroupId = projectgroupId;
    }
}

public sealed class ProjectGroupDeletedEvent : DomainEvent
{
    public ProjectGroupId ProjectGroupId { get; }

    public ProjectGroupDeletedEvent(ProjectGroupId projectgroupId)
    {
        ProjectGroupId = projectgroupId;
    }
}
}
