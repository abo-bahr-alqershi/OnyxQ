using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxSlice entity
/// </summary>
public sealed class TaxSliceCreatedEvent : DomainEvent
{
    public TaxSliceId TaxSliceId { get; }

    public TaxSliceCreatedEvent(TaxSliceId taxsliceId)
    {
        TaxSliceId = taxsliceId;
    }
}

public sealed class TaxSliceUpdatedEvent : DomainEvent
{
    public TaxSliceId TaxSliceId { get; }

    public TaxSliceUpdatedEvent(TaxSliceId taxsliceId)
    {
        TaxSliceId = taxsliceId;
    }
}

public sealed class TaxSliceDeletedEvent : DomainEvent
{
    public TaxSliceId TaxSliceId { get; }

    public TaxSliceDeletedEvent(TaxSliceId taxsliceId)
    {
        TaxSliceId = taxsliceId;
    }
}
}
