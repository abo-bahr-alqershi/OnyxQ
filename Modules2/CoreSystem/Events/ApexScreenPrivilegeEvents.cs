using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApexScreenPrivilege entity
/// </summary>
public sealed class ApexScreenPrivilegeCreatedEvent : DomainEvent
{
    public ApexScreenPrivilegeId ApexScreenPrivilegeId { get; }

    public ApexScreenPrivilegeCreatedEvent(ApexScreenPrivilegeId apexscreenprivilegeId)
    {
        ApexScreenPrivilegeId = apexscreenprivilegeId;
    }
}

public sealed class ApexScreenPrivilegeUpdatedEvent : DomainEvent
{
    public ApexScreenPrivilegeId ApexScreenPrivilegeId { get; }

    public ApexScreenPrivilegeUpdatedEvent(ApexScreenPrivilegeId apexscreenprivilegeId)
    {
        ApexScreenPrivilegeId = apexscreenprivilegeId;
    }
}

public sealed class ApexScreenPrivilegeDeletedEvent : DomainEvent
{
    public ApexScreenPrivilegeId ApexScreenPrivilegeId { get; }

    public ApexScreenPrivilegeDeletedEvent(ApexScreenPrivilegeId apexscreenprivilegeId)
    {
        ApexScreenPrivilegeId = apexscreenprivilegeId;
    }
}
}
