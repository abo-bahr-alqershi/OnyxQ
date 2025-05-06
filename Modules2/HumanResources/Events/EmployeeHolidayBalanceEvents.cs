using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeHolidayBalance entity
/// </summary>
public sealed class EmployeeHolidayBalanceCreatedEvent : DomainEvent
{
    public EmployeeHolidayBalanceId EmployeeHolidayBalanceId { get; }

    public EmployeeHolidayBalanceCreatedEvent(EmployeeHolidayBalanceId employeeholidaybalanceId)
    {
        EmployeeHolidayBalanceId = employeeholidaybalanceId;
    }
}

public sealed class EmployeeHolidayBalanceUpdatedEvent : DomainEvent
{
    public EmployeeHolidayBalanceId EmployeeHolidayBalanceId { get; }

    public EmployeeHolidayBalanceUpdatedEvent(EmployeeHolidayBalanceId employeeholidaybalanceId)
    {
        EmployeeHolidayBalanceId = employeeholidaybalanceId;
    }
}

public sealed class EmployeeHolidayBalanceDeletedEvent : DomainEvent
{
    public EmployeeHolidayBalanceId EmployeeHolidayBalanceId { get; }

    public EmployeeHolidayBalanceDeletedEvent(EmployeeHolidayBalanceId employeeholidaybalanceId)
    {
        EmployeeHolidayBalanceId = employeeholidaybalanceId;
    }
}
}
