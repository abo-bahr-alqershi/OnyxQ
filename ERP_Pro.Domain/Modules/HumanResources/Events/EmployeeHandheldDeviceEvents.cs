using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeHandheldDevice entity
/// </summary>
public sealed class EmployeeHandheldDeviceCreatedEvent : DomainEvent
{
    public EmployeeHandheldDeviceId EmployeeHandheldDeviceId { get; }

    public EmployeeHandheldDeviceCreatedEvent(EmployeeHandheldDeviceId employeehandhelddeviceId)
    {
        EmployeeHandheldDeviceId = employeehandhelddeviceId;
    }
}

public sealed class EmployeeHandheldDeviceUpdatedEvent : DomainEvent
{
    public EmployeeHandheldDeviceId EmployeeHandheldDeviceId { get; }

    public EmployeeHandheldDeviceUpdatedEvent(EmployeeHandheldDeviceId employeehandhelddeviceId)
    {
        EmployeeHandheldDeviceId = employeehandhelddeviceId;
    }
}

public sealed class EmployeeHandheldDeviceDeletedEvent : DomainEvent
{
    public EmployeeHandheldDeviceId EmployeeHandheldDeviceId { get; }

    public EmployeeHandheldDeviceDeletedEvent(EmployeeHandheldDeviceId employeehandhelddeviceId)
    {
        EmployeeHandheldDeviceId = employeehandhelddeviceId;
    }
}
}
