using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeMovement entity
/// </summary>
public sealed class EmployeeMovementCreatedEvent : DomainEvent
{
    public EmployeeMovementId EmployeeMovementId { get; }

    public EmployeeMovementCreatedEvent(EmployeeMovementId employeemovementId)
    {
        EmployeeMovementId = employeemovementId;
    }
}

public sealed class EmployeeMovementUpdatedEvent : DomainEvent
{
    public EmployeeMovementId EmployeeMovementId { get; }

    public EmployeeMovementUpdatedEvent(EmployeeMovementId employeemovementId)
    {
        EmployeeMovementId = employeemovementId;
    }
}

public sealed class EmployeeMovementDeletedEvent : DomainEvent
{
    public EmployeeMovementId EmployeeMovementId { get; }

    public EmployeeMovementDeletedEvent(EmployeeMovementId employeemovementId)
    {
        EmployeeMovementId = employeemovementId;
    }
}
}
