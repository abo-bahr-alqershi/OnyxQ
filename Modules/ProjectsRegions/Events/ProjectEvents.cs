using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Project entity
/// </summary>
public sealed class ProjectCreatedEvent : DomainEvent
{
    public ProjectId ProjectId { get; }

    public ProjectCreatedEvent(ProjectId projectId)
    {
        ProjectId = projectId;
    }
}

public sealed class ProjectUpdatedEvent : DomainEvent
{
    public ProjectId ProjectId { get; }

    public ProjectUpdatedEvent(ProjectId projectId)
    {
        ProjectId = projectId;
    }
}

public sealed class ProjectDeletedEvent : DomainEvent
{
    public ProjectId ProjectId { get; }

    public ProjectDeletedEvent(ProjectId projectId)
    {
        ProjectId = projectId;
    }
}
}
