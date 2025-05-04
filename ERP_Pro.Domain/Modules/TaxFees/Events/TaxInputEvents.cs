using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxInput entity
/// </summary>
public sealed class TaxInputCreatedEvent : DomainEvent
{
    public TaxInputId TaxInputId { get; }

    public TaxInputCreatedEvent(TaxInputId taxinputId)
    {
        TaxInputId = taxinputId;
    }
}

public sealed class TaxInputUpdatedEvent : DomainEvent
{
    public TaxInputId TaxInputId { get; }

    public TaxInputUpdatedEvent(TaxInputId taxinputId)
    {
        TaxInputId = taxinputId;
    }
}

public sealed class TaxInputDeletedEvent : DomainEvent
{
    public TaxInputId TaxInputId { get; }

    public TaxInputDeletedEvent(TaxInputId taxinputId)
    {
        TaxInputId = taxinputId;
    }
}
}
