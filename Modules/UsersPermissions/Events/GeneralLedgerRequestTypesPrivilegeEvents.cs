using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestTypesPrivilege entity
/// </summary>
public sealed class GeneralLedgerRequestTypesPrivilegeCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesPrivilegeId GeneralLedgerRequestTypesPrivilegeId { get; }

    public GeneralLedgerRequestTypesPrivilegeCreatedEvent(GeneralLedgerRequestTypesPrivilegeId generalledgerrequesttypesprivilegeId)
    {
        GeneralLedgerRequestTypesPrivilegeId = generalledgerrequesttypesprivilegeId;
    }
}

public sealed class GeneralLedgerRequestTypesPrivilegeUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesPrivilegeId GeneralLedgerRequestTypesPrivilegeId { get; }

    public GeneralLedgerRequestTypesPrivilegeUpdatedEvent(GeneralLedgerRequestTypesPrivilegeId generalledgerrequesttypesprivilegeId)
    {
        GeneralLedgerRequestTypesPrivilegeId = generalledgerrequesttypesprivilegeId;
    }
}

public sealed class GeneralLedgerRequestTypesPrivilegeDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesPrivilegeId GeneralLedgerRequestTypesPrivilegeId { get; }

    public GeneralLedgerRequestTypesPrivilegeDeletedEvent(GeneralLedgerRequestTypesPrivilegeId generalledgerrequesttypesprivilegeId)
    {
        GeneralLedgerRequestTypesPrivilegeId = generalledgerrequesttypesprivilegeId;
    }
}
}
