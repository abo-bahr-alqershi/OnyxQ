using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeCodeMaster entity
/// </summary>
public sealed class EmployeeCodeMasterCreatedEvent : DomainEvent
{
    public EmployeeCodeMasterId EmployeeCodeMasterId { get; }

    public EmployeeCodeMasterCreatedEvent(EmployeeCodeMasterId employeecodemasterId)
    {
        EmployeeCodeMasterId = employeecodemasterId;
    }
}

public sealed class EmployeeCodeMasterUpdatedEvent : DomainEvent
{
    public EmployeeCodeMasterId EmployeeCodeMasterId { get; }

    public EmployeeCodeMasterUpdatedEvent(EmployeeCodeMasterId employeecodemasterId)
    {
        EmployeeCodeMasterId = employeecodemasterId;
    }
}

public sealed class EmployeeCodeMasterDeletedEvent : DomainEvent
{
    public EmployeeCodeMasterId EmployeeCodeMasterId { get; }

    public EmployeeCodeMasterDeletedEvent(EmployeeCodeMasterId employeecodemasterId)
    {
        EmployeeCodeMasterId = employeecodemasterId;
    }
}
}
