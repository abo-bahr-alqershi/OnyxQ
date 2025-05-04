using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestMaster entity
/// </summary>
public sealed class GeneralLedgerRequestMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestMasterId GeneralLedgerRequestMasterId { get; }

    public GeneralLedgerRequestMasterCreatedEvent(GeneralLedgerRequestMasterId generalledgerrequestmasterId)
    {
        GeneralLedgerRequestMasterId = generalledgerrequestmasterId;
    }
}

public sealed class GeneralLedgerRequestMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestMasterId GeneralLedgerRequestMasterId { get; }

    public GeneralLedgerRequestMasterUpdatedEvent(GeneralLedgerRequestMasterId generalledgerrequestmasterId)
    {
        GeneralLedgerRequestMasterId = generalledgerrequestmasterId;
    }
}

public sealed class GeneralLedgerRequestMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestMasterId GeneralLedgerRequestMasterId { get; }

    public GeneralLedgerRequestMasterDeletedEvent(GeneralLedgerRequestMasterId generalledgerrequestmasterId)
    {
        GeneralLedgerRequestMasterId = generalledgerrequestmasterId;
    }
}
}
