using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to EmployeeCommissionSetupMaster entity
/// </summary>
public sealed class EmployeeCommissionSetupMasterCreatedEvent : DomainEvent
{
    public EmployeeCommissionSetupMasterId EmployeeCommissionSetupMasterId { get; }

    public EmployeeCommissionSetupMasterCreatedEvent(EmployeeCommissionSetupMasterId employeecommissionsetupmasterId)
    {
        EmployeeCommissionSetupMasterId = employeecommissionsetupmasterId;
    }
}

public sealed class EmployeeCommissionSetupMasterUpdatedEvent : DomainEvent
{
    public EmployeeCommissionSetupMasterId EmployeeCommissionSetupMasterId { get; }

    public EmployeeCommissionSetupMasterUpdatedEvent(EmployeeCommissionSetupMasterId employeecommissionsetupmasterId)
    {
        EmployeeCommissionSetupMasterId = employeecommissionsetupmasterId;
    }
}

public sealed class EmployeeCommissionSetupMasterDeletedEvent : DomainEvent
{
    public EmployeeCommissionSetupMasterId EmployeeCommissionSetupMasterId { get; }

    public EmployeeCommissionSetupMasterDeletedEvent(EmployeeCommissionSetupMasterId employeecommissionsetupmasterId)
    {
        EmployeeCommissionSetupMasterId = employeecommissionsetupmasterId;
    }
}
}
