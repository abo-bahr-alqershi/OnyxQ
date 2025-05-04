using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxItem entity
/// </summary>
public sealed class TaxItemCreatedEvent : DomainEvent
{
    public TaxItemId TaxItemId { get; }

    public TaxItemCreatedEvent(TaxItemId taxitemId)
    {
        TaxItemId = taxitemId;
    }
}

public sealed class TaxItemUpdatedEvent : DomainEvent
{
    public TaxItemId TaxItemId { get; }

    public TaxItemUpdatedEvent(TaxItemId taxitemId)
    {
        TaxItemId = taxitemId;
    }
}

public sealed class TaxItemDeletedEvent : DomainEvent
{
    public TaxItemId TaxItemId { get; }

    public TaxItemDeletedEvent(TaxItemId taxitemId)
    {
        TaxItemId = taxitemId;
    }
}
}
