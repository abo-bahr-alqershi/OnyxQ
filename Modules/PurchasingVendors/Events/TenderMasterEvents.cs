using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to TenderMaster entity
/// </summary>
public sealed class TenderMasterCreatedEvent : DomainEvent
{
    public TenderMasterId TenderMasterId { get; }

    public TenderMasterCreatedEvent(TenderMasterId tendermasterId)
    {
        TenderMasterId = tendermasterId;
    }
}

public sealed class TenderMasterUpdatedEvent : DomainEvent
{
    public TenderMasterId TenderMasterId { get; }

    public TenderMasterUpdatedEvent(TenderMasterId tendermasterId)
    {
        TenderMasterId = tendermasterId;
    }
}

public sealed class TenderMasterDeletedEvent : DomainEvent
{
    public TenderMasterId TenderMasterId { get; }

    public TenderMasterDeletedEvent(TenderMasterId tendermasterId)
    {
        TenderMasterId = tendermasterId;
    }
}
}
