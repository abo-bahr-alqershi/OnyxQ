using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to EmployeeProfessionLink entity
/// </summary>
public sealed class EmployeeProfessionLinkCreatedEvent : DomainEvent
{
    public EmployeeProfessionLinkId EmployeeProfessionLinkId { get; }

    public EmployeeProfessionLinkCreatedEvent(EmployeeProfessionLinkId employeeprofessionlinkId)
    {
        EmployeeProfessionLinkId = employeeprofessionlinkId;
    }
}

public sealed class EmployeeProfessionLinkUpdatedEvent : DomainEvent
{
    public EmployeeProfessionLinkId EmployeeProfessionLinkId { get; }

    public EmployeeProfessionLinkUpdatedEvent(EmployeeProfessionLinkId employeeprofessionlinkId)
    {
        EmployeeProfessionLinkId = employeeprofessionlinkId;
    }
}

public sealed class EmployeeProfessionLinkDeletedEvent : DomainEvent
{
    public EmployeeProfessionLinkId EmployeeProfessionLinkId { get; }

    public EmployeeProfessionLinkDeletedEvent(EmployeeProfessionLinkId employeeprofessionlinkId)
    {
        EmployeeProfessionLinkId = employeeprofessionlinkId;
    }
}
}
