using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeePrivilege entity
/// </summary>
public sealed class EmployeePrivilegeCreatedEvent : DomainEvent
{
    public EmployeePrivilegeId EmployeePrivilegeId { get; }

    public EmployeePrivilegeCreatedEvent(EmployeePrivilegeId employeeprivilegeId)
    {
        EmployeePrivilegeId = employeeprivilegeId;
    }
}

public sealed class EmployeePrivilegeUpdatedEvent : DomainEvent
{
    public EmployeePrivilegeId EmployeePrivilegeId { get; }

    public EmployeePrivilegeUpdatedEvent(EmployeePrivilegeId employeeprivilegeId)
    {
        EmployeePrivilegeId = employeeprivilegeId;
    }
}

public sealed class EmployeePrivilegeDeletedEvent : DomainEvent
{
    public EmployeePrivilegeId EmployeePrivilegeId { get; }

    public EmployeePrivilegeDeletedEvent(EmployeePrivilegeId employeeprivilegeId)
    {
        EmployeePrivilegeId = employeeprivilegeId;
    }
}
}
