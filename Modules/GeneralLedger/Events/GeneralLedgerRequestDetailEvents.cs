using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestDetail entity
/// </summary>
public sealed class GeneralLedgerRequestDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestDetailId GeneralLedgerRequestDetailId { get; }

    public GeneralLedgerRequestDetailCreatedEvent(GeneralLedgerRequestDetailId generalledgerrequestdetailId)
    {
        GeneralLedgerRequestDetailId = generalledgerrequestdetailId;
    }
}

public sealed class GeneralLedgerRequestDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestDetailId GeneralLedgerRequestDetailId { get; }

    public GeneralLedgerRequestDetailUpdatedEvent(GeneralLedgerRequestDetailId generalledgerrequestdetailId)
    {
        GeneralLedgerRequestDetailId = generalledgerrequestdetailId;
    }
}

public sealed class GeneralLedgerRequestDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestDetailId GeneralLedgerRequestDetailId { get; }

    public GeneralLedgerRequestDetailDeletedEvent(GeneralLedgerRequestDetailId generalledgerrequestdetailId)
    {
        GeneralLedgerRequestDetailId = generalledgerrequestdetailId;
    }
}
}
