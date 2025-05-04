using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeGuarantor entity
/// </summary>
public sealed class EmployeeGuarantorCreatedEvent : DomainEvent
{
    public EmployeeGuarantorId EmployeeGuarantorId { get; }

    public EmployeeGuarantorCreatedEvent(EmployeeGuarantorId employeeguarantorId)
    {
        EmployeeGuarantorId = employeeguarantorId;
    }
}

public sealed class EmployeeGuarantorUpdatedEvent : DomainEvent
{
    public EmployeeGuarantorId EmployeeGuarantorId { get; }

    public EmployeeGuarantorUpdatedEvent(EmployeeGuarantorId employeeguarantorId)
    {
        EmployeeGuarantorId = employeeguarantorId;
    }
}

public sealed class EmployeeGuarantorDeletedEvent : DomainEvent
{
    public EmployeeGuarantorId EmployeeGuarantorId { get; }

    public EmployeeGuarantorDeletedEvent(EmployeeGuarantorId employeeguarantorId)
    {
        EmployeeGuarantorId = employeeguarantorId;
    }
}
}
