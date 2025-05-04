using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeProfession entity
/// </summary>
public sealed class EmployeeProfessionCreatedEvent : DomainEvent
{
    public EmployeeProfessionId EmployeeProfessionId { get; }

    public EmployeeProfessionCreatedEvent(EmployeeProfessionId employeeprofessionId)
    {
        EmployeeProfessionId = employeeprofessionId;
    }
}

public sealed class EmployeeProfessionUpdatedEvent : DomainEvent
{
    public EmployeeProfessionId EmployeeProfessionId { get; }

    public EmployeeProfessionUpdatedEvent(EmployeeProfessionId employeeprofessionId)
    {
        EmployeeProfessionId = employeeprofessionId;
    }
}

public sealed class EmployeeProfessionDeletedEvent : DomainEvent
{
    public EmployeeProfessionId EmployeeProfessionId { get; }

    public EmployeeProfessionDeletedEvent(EmployeeProfessionId employeeprofessionId)
    {
        EmployeeProfessionId = employeeprofessionId;
    }
}
}
