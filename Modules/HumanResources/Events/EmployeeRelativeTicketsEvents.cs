using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeRelativeTickets entity
/// </summary>
public sealed class EmployeeRelativeTicketsCreatedEvent : DomainEvent
{
    public EmployeeRelativeTicketsId EmployeeRelativeTicketsId { get; }

    public EmployeeRelativeTicketsCreatedEvent(EmployeeRelativeTicketsId employeerelativeticketsId)
    {
        EmployeeRelativeTicketsId = employeerelativeticketsId;
    }
}

public sealed class EmployeeRelativeTicketsUpdatedEvent : DomainEvent
{
    public EmployeeRelativeTicketsId EmployeeRelativeTicketsId { get; }

    public EmployeeRelativeTicketsUpdatedEvent(EmployeeRelativeTicketsId employeerelativeticketsId)
    {
        EmployeeRelativeTicketsId = employeerelativeticketsId;
    }
}

public sealed class EmployeeRelativeTicketsDeletedEvent : DomainEvent
{
    public EmployeeRelativeTicketsId EmployeeRelativeTicketsId { get; }

    public EmployeeRelativeTicketsDeletedEvent(EmployeeRelativeTicketsId employeerelativeticketsId)
    {
        EmployeeRelativeTicketsId = employeerelativeticketsId;
    }
}
}
