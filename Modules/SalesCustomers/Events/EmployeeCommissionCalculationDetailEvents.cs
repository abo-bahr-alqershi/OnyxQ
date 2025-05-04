using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to EmployeeCommissionCalculationDetail entity
/// </summary>
public sealed class EmployeeCommissionCalculationDetailCreatedEvent : DomainEvent
{
    public EmployeeCommissionCalculationDetailId EmployeeCommissionCalculationDetailId { get; }

    public EmployeeCommissionCalculationDetailCreatedEvent(EmployeeCommissionCalculationDetailId employeecommissioncalculationdetailId)
    {
        EmployeeCommissionCalculationDetailId = employeecommissioncalculationdetailId;
    }
}

public sealed class EmployeeCommissionCalculationDetailUpdatedEvent : DomainEvent
{
    public EmployeeCommissionCalculationDetailId EmployeeCommissionCalculationDetailId { get; }

    public EmployeeCommissionCalculationDetailUpdatedEvent(EmployeeCommissionCalculationDetailId employeecommissioncalculationdetailId)
    {
        EmployeeCommissionCalculationDetailId = employeecommissioncalculationdetailId;
    }
}

public sealed class EmployeeCommissionCalculationDetailDeletedEvent : DomainEvent
{
    public EmployeeCommissionCalculationDetailId EmployeeCommissionCalculationDetailId { get; }

    public EmployeeCommissionCalculationDetailDeletedEvent(EmployeeCommissionCalculationDetailId employeecommissioncalculationdetailId)
    {
        EmployeeCommissionCalculationDetailId = employeecommissioncalculationdetailId;
    }
}
}
