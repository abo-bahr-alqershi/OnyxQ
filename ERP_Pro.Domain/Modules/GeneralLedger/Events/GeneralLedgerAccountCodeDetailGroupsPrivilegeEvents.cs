using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountCodeDetailGroupsPrivilege entity
/// </summary>
public sealed class GeneralLedgerAccountCodeDetailGroupsPrivilegeCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsPrivilegeId GeneralLedgerAccountCodeDetailGroupsPrivilegeId { get; }

    public GeneralLedgerAccountCodeDetailGroupsPrivilegeCreatedEvent(GeneralLedgerAccountCodeDetailGroupsPrivilegeId generalledgeraccountcodedetailgroupsprivilegeId)
    {
        GeneralLedgerAccountCodeDetailGroupsPrivilegeId = generalledgeraccountcodedetailgroupsprivilegeId;
    }
}

public sealed class GeneralLedgerAccountCodeDetailGroupsPrivilegeUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsPrivilegeId GeneralLedgerAccountCodeDetailGroupsPrivilegeId { get; }

    public GeneralLedgerAccountCodeDetailGroupsPrivilegeUpdatedEvent(GeneralLedgerAccountCodeDetailGroupsPrivilegeId generalledgeraccountcodedetailgroupsprivilegeId)
    {
        GeneralLedgerAccountCodeDetailGroupsPrivilegeId = generalledgeraccountcodedetailgroupsprivilegeId;
    }
}

public sealed class GeneralLedgerAccountCodeDetailGroupsPrivilegeDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsPrivilegeId GeneralLedgerAccountCodeDetailGroupsPrivilegeId { get; }

    public GeneralLedgerAccountCodeDetailGroupsPrivilegeDeletedEvent(GeneralLedgerAccountCodeDetailGroupsPrivilegeId generalledgeraccountcodedetailgroupsprivilegeId)
    {
        GeneralLedgerAccountCodeDetailGroupsPrivilegeId = generalledgeraccountcodedetailgroupsprivilegeId;
    }
}
}
