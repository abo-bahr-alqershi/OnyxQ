using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to TrustDetail entity
/// </summary>
public sealed class TrustDetailCreatedEvent : DomainEvent
{
    public TrustDetailId TrustDetailId { get; }

    public TrustDetailCreatedEvent(TrustDetailId trustdetailId)
    {
        TrustDetailId = trustdetailId;
    }
}

public sealed class TrustDetailUpdatedEvent : DomainEvent
{
    public TrustDetailId TrustDetailId { get; }

    public TrustDetailUpdatedEvent(TrustDetailId trustdetailId)
    {
        TrustDetailId = trustdetailId;
    }
}

public sealed class TrustDetailDeletedEvent : DomainEvent
{
    public TrustDetailId TrustDetailId { get; }

    public TrustDetailDeletedEvent(TrustDetailId trustdetailId)
    {
        TrustDetailId = trustdetailId;
    }
}
}
