using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeAttendanceLocation entity
/// </summary>
public sealed class EmployeeAttendanceLocationCreatedEvent : DomainEvent
{
    public EmployeeAttendanceLocationId EmployeeAttendanceLocationId { get; }

    public EmployeeAttendanceLocationCreatedEvent(EmployeeAttendanceLocationId employeeattendancelocationId)
    {
        EmployeeAttendanceLocationId = employeeattendancelocationId;
    }
}

public sealed class EmployeeAttendanceLocationUpdatedEvent : DomainEvent
{
    public EmployeeAttendanceLocationId EmployeeAttendanceLocationId { get; }

    public EmployeeAttendanceLocationUpdatedEvent(EmployeeAttendanceLocationId employeeattendancelocationId)
    {
        EmployeeAttendanceLocationId = employeeattendancelocationId;
    }
}

public sealed class EmployeeAttendanceLocationDeletedEvent : DomainEvent
{
    public EmployeeAttendanceLocationId EmployeeAttendanceLocationId { get; }

    public EmployeeAttendanceLocationDeletedEvent(EmployeeAttendanceLocationId employeeattendancelocationId)
    {
        EmployeeAttendanceLocationId = employeeattendancelocationId;
    }
}
}
