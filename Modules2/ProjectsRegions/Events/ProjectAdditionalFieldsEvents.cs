using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to ProjectAdditionalFields entity
/// </summary>
public sealed class ProjectAdditionalFieldsCreatedEvent : DomainEvent
{
    public ProjectAdditionalFieldsId ProjectAdditionalFieldsId { get; }

    public ProjectAdditionalFieldsCreatedEvent(ProjectAdditionalFieldsId projectadditionalfieldsId)
    {
        ProjectAdditionalFieldsId = projectadditionalfieldsId;
    }
}

public sealed class ProjectAdditionalFieldsUpdatedEvent : DomainEvent
{
    public ProjectAdditionalFieldsId ProjectAdditionalFieldsId { get; }

    public ProjectAdditionalFieldsUpdatedEvent(ProjectAdditionalFieldsId projectadditionalfieldsId)
    {
        ProjectAdditionalFieldsId = projectadditionalfieldsId;
    }
}

public sealed class ProjectAdditionalFieldsDeletedEvent : DomainEvent
{
    public ProjectAdditionalFieldsId ProjectAdditionalFieldsId { get; }

    public ProjectAdditionalFieldsDeletedEvent(ProjectAdditionalFieldsId projectadditionalfieldsId)
    {
        ProjectAdditionalFieldsId = projectadditionalfieldsId;
    }
}
}
