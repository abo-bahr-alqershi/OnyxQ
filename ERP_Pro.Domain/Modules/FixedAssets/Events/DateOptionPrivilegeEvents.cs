using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FixedAssets.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Events
{
/// <summary>
/// Events related to DateOptionPrivilege entity
/// </summary>
public sealed class DateOptionPrivilegeCreatedEvent : DomainEvent
{
    public DateOptionPrivilegeId DateOptionPrivilegeId { get; }

    public DateOptionPrivilegeCreatedEvent(DateOptionPrivilegeId dateoptionprivilegeId)
    {
        DateOptionPrivilegeId = dateoptionprivilegeId;
    }
}

public sealed class DateOptionPrivilegeUpdatedEvent : DomainEvent
{
    public DateOptionPrivilegeId DateOptionPrivilegeId { get; }

    public DateOptionPrivilegeUpdatedEvent(DateOptionPrivilegeId dateoptionprivilegeId)
    {
        DateOptionPrivilegeId = dateoptionprivilegeId;
    }
}

public sealed class DateOptionPrivilegeDeletedEvent : DomainEvent
{
    public DateOptionPrivilegeId DateOptionPrivilegeId { get; }

    public DateOptionPrivilegeDeletedEvent(DateOptionPrivilegeId dateoptionprivilegeId)
    {
        DateOptionPrivilegeId = dateoptionprivilegeId;
    }
}
}
