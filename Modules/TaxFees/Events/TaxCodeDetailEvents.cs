using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxCodeDetail entity
/// </summary>
public sealed class TaxCodeDetailCreatedEvent : DomainEvent
{
    public TaxCodeDetailId TaxCodeDetailId { get; }

    public TaxCodeDetailCreatedEvent(TaxCodeDetailId taxcodedetailId)
    {
        TaxCodeDetailId = taxcodedetailId;
    }
}

public sealed class TaxCodeDetailUpdatedEvent : DomainEvent
{
    public TaxCodeDetailId TaxCodeDetailId { get; }

    public TaxCodeDetailUpdatedEvent(TaxCodeDetailId taxcodedetailId)
    {
        TaxCodeDetailId = taxcodedetailId;
    }
}

public sealed class TaxCodeDetailDeletedEvent : DomainEvent
{
    public TaxCodeDetailId TaxCodeDetailId { get; }

    public TaxCodeDetailDeletedEvent(TaxCodeDetailId taxcodedetailId)
    {
        TaxCodeDetailId = taxcodedetailId;
    }
}
}
