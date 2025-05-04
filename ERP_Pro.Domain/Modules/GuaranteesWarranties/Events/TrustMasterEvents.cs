using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to TrustMaster entity
/// </summary>
public sealed class TrustMasterCreatedEvent : DomainEvent
{
    public TrustMasterId TrustMasterId { get; }

    public TrustMasterCreatedEvent(TrustMasterId trustmasterId)
    {
        TrustMasterId = trustmasterId;
    }
}

public sealed class TrustMasterUpdatedEvent : DomainEvent
{
    public TrustMasterId TrustMasterId { get; }

    public TrustMasterUpdatedEvent(TrustMasterId trustmasterId)
    {
        TrustMasterId = trustmasterId;
    }
}

public sealed class TrustMasterDeletedEvent : DomainEvent
{
    public TrustMasterId TrustMasterId { get; }

    public TrustMasterDeletedEvent(TrustMasterId trustmasterId)
    {
        TrustMasterId = trustmasterId;
    }
}
}
