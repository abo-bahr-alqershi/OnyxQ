using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountCodeDetailGroups entity
/// </summary>
public sealed class GeneralLedgerAccountCodeDetailGroupsCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsId GeneralLedgerAccountCodeDetailGroupsId { get; }

    public GeneralLedgerAccountCodeDetailGroupsCreatedEvent(GeneralLedgerAccountCodeDetailGroupsId generalledgeraccountcodedetailgroupsId)
    {
        GeneralLedgerAccountCodeDetailGroupsId = generalledgeraccountcodedetailgroupsId;
    }
}

public sealed class GeneralLedgerAccountCodeDetailGroupsUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsId GeneralLedgerAccountCodeDetailGroupsId { get; }

    public GeneralLedgerAccountCodeDetailGroupsUpdatedEvent(GeneralLedgerAccountCodeDetailGroupsId generalledgeraccountcodedetailgroupsId)
    {
        GeneralLedgerAccountCodeDetailGroupsId = generalledgeraccountcodedetailgroupsId;
    }
}

public sealed class GeneralLedgerAccountCodeDetailGroupsDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountCodeDetailGroupsId GeneralLedgerAccountCodeDetailGroupsId { get; }

    public GeneralLedgerAccountCodeDetailGroupsDeletedEvent(GeneralLedgerAccountCodeDetailGroupsId generalledgeraccountcodedetailgroupsId)
    {
        GeneralLedgerAccountCodeDetailGroupsId = generalledgeraccountcodedetailgroupsId;
    }
}
}
