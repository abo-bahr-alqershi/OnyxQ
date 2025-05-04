using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ScreenCssPrivilege entity
/// </summary>
public sealed class ScreenCssPrivilegeCreatedEvent : DomainEvent
{
    public ScreenCssPrivilegeId ScreenCssPrivilegeId { get; }

    public ScreenCssPrivilegeCreatedEvent(ScreenCssPrivilegeId screencssprivilegeId)
    {
        ScreenCssPrivilegeId = screencssprivilegeId;
    }
}

public sealed class ScreenCssPrivilegeUpdatedEvent : DomainEvent
{
    public ScreenCssPrivilegeId ScreenCssPrivilegeId { get; }

    public ScreenCssPrivilegeUpdatedEvent(ScreenCssPrivilegeId screencssprivilegeId)
    {
        ScreenCssPrivilegeId = screencssprivilegeId;
    }
}

public sealed class ScreenCssPrivilegeDeletedEvent : DomainEvent
{
    public ScreenCssPrivilegeId ScreenCssPrivilegeId { get; }

    public ScreenCssPrivilegeDeletedEvent(ScreenCssPrivilegeId screencssprivilegeId)
    {
        ScreenCssPrivilegeId = screencssprivilegeId;
    }
}
}
