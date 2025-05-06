using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeBank entity
/// </summary>
public sealed class EmployeeBankCreatedEvent : DomainEvent
{
    public EmployeeBankId EmployeeBankId { get; }

    public EmployeeBankCreatedEvent(EmployeeBankId employeebankId)
    {
        EmployeeBankId = employeebankId;
    }
}

public sealed class EmployeeBankUpdatedEvent : DomainEvent
{
    public EmployeeBankId EmployeeBankId { get; }

    public EmployeeBankUpdatedEvent(EmployeeBankId employeebankId)
    {
        EmployeeBankId = employeebankId;
    }
}

public sealed class EmployeeBankDeletedEvent : DomainEvent
{
    public EmployeeBankId EmployeeBankId { get; }

    public EmployeeBankDeletedEvent(EmployeeBankId employeebankId)
    {
        EmployeeBankId = employeebankId;
    }
}
}
