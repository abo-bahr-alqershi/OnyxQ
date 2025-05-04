using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to ProjectTree entity
/// </summary>
public sealed class ProjectTreeCreatedEvent : DomainEvent
{
    public ProjectTreeId ProjectTreeId { get; }

    public ProjectTreeCreatedEvent(ProjectTreeId projecttreeId)
    {
        ProjectTreeId = projecttreeId;
    }
}

public sealed class ProjectTreeUpdatedEvent : DomainEvent
{
    public ProjectTreeId ProjectTreeId { get; }

    public ProjectTreeUpdatedEvent(ProjectTreeId projecttreeId)
    {
        ProjectTreeId = projecttreeId;
    }
}

public sealed class ProjectTreeDeletedEvent : DomainEvent
{
    public ProjectTreeId ProjectTreeId { get; }

    public ProjectTreeDeletedEvent(ProjectTreeId projecttreeId)
    {
        ProjectTreeId = projecttreeId;
    }
}
}
