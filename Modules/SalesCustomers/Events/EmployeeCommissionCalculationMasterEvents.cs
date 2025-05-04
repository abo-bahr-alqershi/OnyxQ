using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to EmployeeCommissionCalculationMaster entity
/// </summary>
public sealed class EmployeeCommissionCalculationMasterCreatedEvent : DomainEvent
{
    public EmployeeCommissionCalculationMasterId EmployeeCommissionCalculationMasterId { get; }

    public EmployeeCommissionCalculationMasterCreatedEvent(EmployeeCommissionCalculationMasterId employeecommissioncalculationmasterId)
    {
        EmployeeCommissionCalculationMasterId = employeecommissioncalculationmasterId;
    }
}

public sealed class EmployeeCommissionCalculationMasterUpdatedEvent : DomainEvent
{
    public EmployeeCommissionCalculationMasterId EmployeeCommissionCalculationMasterId { get; }

    public EmployeeCommissionCalculationMasterUpdatedEvent(EmployeeCommissionCalculationMasterId employeecommissioncalculationmasterId)
    {
        EmployeeCommissionCalculationMasterId = employeecommissioncalculationmasterId;
    }
}

public sealed class EmployeeCommissionCalculationMasterDeletedEvent : DomainEvent
{
    public EmployeeCommissionCalculationMasterId EmployeeCommissionCalculationMasterId { get; }

    public EmployeeCommissionCalculationMasterDeletedEvent(EmployeeCommissionCalculationMasterId employeecommissioncalculationmasterId)
    {
        EmployeeCommissionCalculationMasterId = employeecommissioncalculationmasterId;
    }
}
}
