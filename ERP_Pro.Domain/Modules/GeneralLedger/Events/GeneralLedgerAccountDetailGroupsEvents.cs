using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerAccountDetailGroups entity
/// </summary>
public sealed class GeneralLedgerAccountDetailGroupsCreatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailGroupsId GeneralLedgerAccountDetailGroupsId { get; }

    public GeneralLedgerAccountDetailGroupsCreatedEvent(GeneralLedgerAccountDetailGroupsId generalledgeraccountdetailgroupsId)
    {
        GeneralLedgerAccountDetailGroupsId = generalledgeraccountdetailgroupsId;
    }
}

public sealed class GeneralLedgerAccountDetailGroupsUpdatedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailGroupsId GeneralLedgerAccountDetailGroupsId { get; }

    public GeneralLedgerAccountDetailGroupsUpdatedEvent(GeneralLedgerAccountDetailGroupsId generalledgeraccountdetailgroupsId)
    {
        GeneralLedgerAccountDetailGroupsId = generalledgeraccountdetailgroupsId;
    }
}

public sealed class GeneralLedgerAccountDetailGroupsDeletedEvent : DomainEvent
{
    public GeneralLedgerAccountDetailGroupsId GeneralLedgerAccountDetailGroupsId { get; }

    public GeneralLedgerAccountDetailGroupsDeletedEvent(GeneralLedgerAccountDetailGroupsId generalledgeraccountdetailgroupsId)
    {
        GeneralLedgerAccountDetailGroupsId = generalledgeraccountdetailgroupsId;
    }
}
}
