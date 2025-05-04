using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestTypes entity
/// </summary>
public sealed class GeneralLedgerRequestTypesCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesId GeneralLedgerRequestTypesId { get; }

    public GeneralLedgerRequestTypesCreatedEvent(GeneralLedgerRequestTypesId generalledgerrequesttypesId)
    {
        GeneralLedgerRequestTypesId = generalledgerrequesttypesId;
    }
}

public sealed class GeneralLedgerRequestTypesUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesId GeneralLedgerRequestTypesId { get; }

    public GeneralLedgerRequestTypesUpdatedEvent(GeneralLedgerRequestTypesId generalledgerrequesttypesId)
    {
        GeneralLedgerRequestTypesId = generalledgerrequesttypesId;
    }
}

public sealed class GeneralLedgerRequestTypesDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestTypesId GeneralLedgerRequestTypesId { get; }

    public GeneralLedgerRequestTypesDeletedEvent(GeneralLedgerRequestTypesId generalledgerrequesttypesId)
    {
        GeneralLedgerRequestTypesId = generalledgerrequesttypesId;
    }
}
}
