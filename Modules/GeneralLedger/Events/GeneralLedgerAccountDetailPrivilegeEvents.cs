using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountDetailPrivilege entity
/// </summary>
public sealed class GeneralLedgerAccountDetailPrivilegeCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailPrivilegeId GeneralLedgerAccountDetailPrivilegeId { get; }

    public GeneralLedgerAccountDetailPrivilegeCreatedEvent(GeneralLedgerAccountDetailPrivilegeId generalledgeraccountdetailprivilegeId)
    {
        GeneralLedgerAccountDetailPrivilegeId = generalledgeraccountdetailprivilegeId;
    }
}

public sealed class GeneralLedgerAccountDetailPrivilegeUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailPrivilegeId GeneralLedgerAccountDetailPrivilegeId { get; }

    public GeneralLedgerAccountDetailPrivilegeUpdatedEvent(GeneralLedgerAccountDetailPrivilegeId generalledgeraccountdetailprivilegeId)
    {
        GeneralLedgerAccountDetailPrivilegeId = generalledgeraccountdetailprivilegeId;
    }
}

public sealed class GeneralLedgerAccountDetailPrivilegeDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailPrivilegeId GeneralLedgerAccountDetailPrivilegeId { get; }

    public GeneralLedgerAccountDetailPrivilegeDeletedEvent(GeneralLedgerAccountDetailPrivilegeId generalledgeraccountdetailprivilegeId)
    {
        GeneralLedgerAccountDetailPrivilegeId = generalledgeraccountdetailprivilegeId;
    }
}
}
