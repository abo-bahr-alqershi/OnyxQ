using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to GeneralCodePrivilege entity
/// </summary>
public sealed class GeneralCodePrivilegeCreatedEvent : DomainEvent
{
    public GeneralCodePrivilegeId GeneralCodePrivilegeId { get; }

    public GeneralCodePrivilegeCreatedEvent(GeneralCodePrivilegeId generalcodeprivilegeId)
    {
        GeneralCodePrivilegeId = generalcodeprivilegeId;
    }
}

public sealed class GeneralCodePrivilegeUpdatedEvent : DomainEvent
{
    public GeneralCodePrivilegeId GeneralCodePrivilegeId { get; }

    public GeneralCodePrivilegeUpdatedEvent(GeneralCodePrivilegeId generalcodeprivilegeId)
    {
        GeneralCodePrivilegeId = generalcodeprivilegeId;
    }
}

public sealed class GeneralCodePrivilegeDeletedEvent : DomainEvent
{
    public GeneralCodePrivilegeId GeneralCodePrivilegeId { get; }

    public GeneralCodePrivilegeDeletedEvent(GeneralCodePrivilegeId generalcodeprivilegeId)
    {
        GeneralCodePrivilegeId = generalcodeprivilegeId;
    }
}
}
