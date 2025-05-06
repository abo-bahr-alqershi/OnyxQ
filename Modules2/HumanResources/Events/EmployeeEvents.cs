using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to Employee entity
/// </summary>
public sealed class EmployeeCreatedEvent : DomainEvent
{
    public EmployeeId EmployeeId { get; }

    public EmployeeCreatedEvent(EmployeeId employeeId)
    {
        EmployeeId = employeeId;
    }
}

public sealed class EmployeeUpdatedEvent : DomainEvent
{
    public EmployeeId EmployeeId { get; }

    public EmployeeUpdatedEvent(EmployeeId employeeId)
    {
        EmployeeId = employeeId;
    }
}

public sealed class EmployeeDeletedEvent : DomainEvent
{
    public EmployeeId EmployeeId { get; }

    public EmployeeDeletedEvent(EmployeeId employeeId)
    {
        EmployeeId = employeeId;
    }
}
}
