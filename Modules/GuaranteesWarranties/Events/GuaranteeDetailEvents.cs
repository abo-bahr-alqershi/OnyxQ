using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeDetail entity
/// </summary>
public sealed class GuaranteeDetailCreatedEvent : DomainEvent
{
    public GuaranteeDetailId GuaranteeDetailId { get; }

    public GuaranteeDetailCreatedEvent(GuaranteeDetailId guaranteedetailId)
    {
        GuaranteeDetailId = guaranteedetailId;
    }
}

public sealed class GuaranteeDetailUpdatedEvent : DomainEvent
{
    public GuaranteeDetailId GuaranteeDetailId { get; }

    public GuaranteeDetailUpdatedEvent(GuaranteeDetailId guaranteedetailId)
    {
        GuaranteeDetailId = guaranteedetailId;
    }
}

public sealed class GuaranteeDetailDeletedEvent : DomainEvent
{
    public GuaranteeDetailId GuaranteeDetailId { get; }

    public GuaranteeDetailDeletedEvent(GuaranteeDetailId guaranteedetailId)
    {
        GuaranteeDetailId = guaranteedetailId;
    }
}
}
