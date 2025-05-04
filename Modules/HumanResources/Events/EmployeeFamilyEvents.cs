using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeFamily entity
/// </summary>
public sealed class EmployeeFamilyCreatedEvent : DomainEvent
{
    public EmployeeFamilyId EmployeeFamilyId { get; }

    public EmployeeFamilyCreatedEvent(EmployeeFamilyId employeefamilyId)
    {
        EmployeeFamilyId = employeefamilyId;
    }
}

public sealed class EmployeeFamilyUpdatedEvent : DomainEvent
{
    public EmployeeFamilyId EmployeeFamilyId { get; }

    public EmployeeFamilyUpdatedEvent(EmployeeFamilyId employeefamilyId)
    {
        EmployeeFamilyId = employeefamilyId;
    }
}

public sealed class EmployeeFamilyDeletedEvent : DomainEvent
{
    public EmployeeFamilyId EmployeeFamilyId { get; }

    public EmployeeFamilyDeletedEvent(EmployeeFamilyId employeefamilyId)
    {
        EmployeeFamilyId = employeefamilyId;
    }
}
}
