using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to EmployeeCommissionSetupDetail entity
/// </summary>
public sealed class EmployeeCommissionSetupDetailCreatedEvent : DomainEvent
{
    public EmployeeCommissionSetupDetailId EmployeeCommissionSetupDetailId { get; }

    public EmployeeCommissionSetupDetailCreatedEvent(EmployeeCommissionSetupDetailId employeecommissionsetupdetailId)
    {
        EmployeeCommissionSetupDetailId = employeecommissionsetupdetailId;
    }
}

public sealed class EmployeeCommissionSetupDetailUpdatedEvent : DomainEvent
{
    public EmployeeCommissionSetupDetailId EmployeeCommissionSetupDetailId { get; }

    public EmployeeCommissionSetupDetailUpdatedEvent(EmployeeCommissionSetupDetailId employeecommissionsetupdetailId)
    {
        EmployeeCommissionSetupDetailId = employeecommissionsetupdetailId;
    }
}

public sealed class EmployeeCommissionSetupDetailDeletedEvent : DomainEvent
{
    public EmployeeCommissionSetupDetailId EmployeeCommissionSetupDetailId { get; }

    public EmployeeCommissionSetupDetailDeletedEvent(EmployeeCommissionSetupDetailId employeecommissionsetupdetailId)
    {
        EmployeeCommissionSetupDetailId = employeecommissionsetupdetailId;
    }
}
}
