using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeKnowledge entity
/// </summary>
public sealed class EmployeeKnowledgeCreatedEvent : DomainEvent
{
    public EmployeeKnowledgeId EmployeeKnowledgeId { get; }

    public EmployeeKnowledgeCreatedEvent(EmployeeKnowledgeId employeeknowledgeId)
    {
        EmployeeKnowledgeId = employeeknowledgeId;
    }
}

public sealed class EmployeeKnowledgeUpdatedEvent : DomainEvent
{
    public EmployeeKnowledgeId EmployeeKnowledgeId { get; }

    public EmployeeKnowledgeUpdatedEvent(EmployeeKnowledgeId employeeknowledgeId)
    {
        EmployeeKnowledgeId = employeeknowledgeId;
    }
}

public sealed class EmployeeKnowledgeDeletedEvent : DomainEvent
{
    public EmployeeKnowledgeId EmployeeKnowledgeId { get; }

    public EmployeeKnowledgeDeletedEvent(EmployeeKnowledgeId employeeknowledgeId)
    {
        EmployeeKnowledgeId = employeeknowledgeId;
    }
}
}
