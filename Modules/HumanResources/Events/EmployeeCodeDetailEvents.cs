using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeCodeDetail entity
/// </summary>
public sealed class EmployeeCodeDetailCreatedEvent : DomainEvent
{
    public EmployeeCodeDetailId EmployeeCodeDetailId { get; }

    public EmployeeCodeDetailCreatedEvent(EmployeeCodeDetailId employeecodedetailId)
    {
        EmployeeCodeDetailId = employeecodedetailId;
    }
}

public sealed class EmployeeCodeDetailUpdatedEvent : DomainEvent
{
    public EmployeeCodeDetailId EmployeeCodeDetailId { get; }

    public EmployeeCodeDetailUpdatedEvent(EmployeeCodeDetailId employeecodedetailId)
    {
        EmployeeCodeDetailId = employeecodedetailId;
    }
}

public sealed class EmployeeCodeDetailDeletedEvent : DomainEvent
{
    public EmployeeCodeDetailId EmployeeCodeDetailId { get; }

    public EmployeeCodeDetailDeletedEvent(EmployeeCodeDetailId employeecodedetailId)
    {
        EmployeeCodeDetailId = employeecodedetailId;
    }
}
}
