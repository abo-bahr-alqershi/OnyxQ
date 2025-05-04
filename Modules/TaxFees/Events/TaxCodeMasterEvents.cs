using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxCodeMaster entity
/// </summary>
public sealed class TaxCodeMasterCreatedEvent : DomainEvent
{
    public TaxCodeMasterId TaxCodeMasterId { get; }

    public TaxCodeMasterCreatedEvent(TaxCodeMasterId taxcodemasterId)
    {
        TaxCodeMasterId = taxcodemasterId;
    }
}

public sealed class TaxCodeMasterUpdatedEvent : DomainEvent
{
    public TaxCodeMasterId TaxCodeMasterId { get; }

    public TaxCodeMasterUpdatedEvent(TaxCodeMasterId taxcodemasterId)
    {
        TaxCodeMasterId = taxcodemasterId;
    }
}

public sealed class TaxCodeMasterDeletedEvent : DomainEvent
{
    public TaxCodeMasterId TaxCodeMasterId { get; }

    public TaxCodeMasterDeletedEvent(TaxCodeMasterId taxcodemasterId)
    {
        TaxCodeMasterId = taxcodemasterId;
    }
}
}
