using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeImage entity
/// </summary>
public sealed class EmployeeImageCreatedEvent : DomainEvent
{
    public EmployeeImageId EmployeeImageId { get; }

    public EmployeeImageCreatedEvent(EmployeeImageId employeeimageId)
    {
        EmployeeImageId = employeeimageId;
    }
}

public sealed class EmployeeImageUpdatedEvent : DomainEvent
{
    public EmployeeImageId EmployeeImageId { get; }

    public EmployeeImageUpdatedEvent(EmployeeImageId employeeimageId)
    {
        EmployeeImageId = employeeimageId;
    }
}

public sealed class EmployeeImageDeletedEvent : DomainEvent
{
    public EmployeeImageId EmployeeImageId { get; }

    public EmployeeImageDeletedEvent(EmployeeImageId employeeimageId)
    {
        EmployeeImageId = employeeimageId;
    }
}
}
