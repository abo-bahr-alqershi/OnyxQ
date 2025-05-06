using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to ProjectActivity entity
/// </summary>
public sealed class ProjectActivityCreatedEvent : DomainEvent
{
    public ProjectActivityId ProjectActivityId { get; }

    public ProjectActivityCreatedEvent(ProjectActivityId projectactivityId)
    {
        ProjectActivityId = projectactivityId;
    }
}

public sealed class ProjectActivityUpdatedEvent : DomainEvent
{
    public ProjectActivityId ProjectActivityId { get; }

    public ProjectActivityUpdatedEvent(ProjectActivityId projectactivityId)
    {
        ProjectActivityId = projectactivityId;
    }
}

public sealed class ProjectActivityDeletedEvent : DomainEvent
{
    public ProjectActivityId ProjectActivityId { get; }

    public ProjectActivityDeletedEvent(ProjectActivityId projectactivityId)
    {
        ProjectActivityId = projectactivityId;
    }
}
}
