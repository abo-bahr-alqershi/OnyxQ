using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeSponsor entity
/// </summary>
public sealed class EmployeeSponsorCreatedEvent : DomainEvent
{
    public EmployeeSponsorId EmployeeSponsorId { get; }

    public EmployeeSponsorCreatedEvent(EmployeeSponsorId employeesponsorId)
    {
        EmployeeSponsorId = employeesponsorId;
    }
}

public sealed class EmployeeSponsorUpdatedEvent : DomainEvent
{
    public EmployeeSponsorId EmployeeSponsorId { get; }

    public EmployeeSponsorUpdatedEvent(EmployeeSponsorId employeesponsorId)
    {
        EmployeeSponsorId = employeesponsorId;
    }
}

public sealed class EmployeeSponsorDeletedEvent : DomainEvent
{
    public EmployeeSponsorId EmployeeSponsorId { get; }

    public EmployeeSponsorDeletedEvent(EmployeeSponsorId employeesponsorId)
    {
        EmployeeSponsorId = employeesponsorId;
    }
}
}
