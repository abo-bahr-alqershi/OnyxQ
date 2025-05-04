using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeType entity
/// </summary>
public sealed class GuaranteeTypeCreatedEvent : DomainEvent
{
    public GuaranteeTypeId GuaranteeTypeId { get; }

    public GuaranteeTypeCreatedEvent(GuaranteeTypeId guaranteetypeId)
    {
        GuaranteeTypeId = guaranteetypeId;
    }
}

public sealed class GuaranteeTypeUpdatedEvent : DomainEvent
{
    public GuaranteeTypeId GuaranteeTypeId { get; }

    public GuaranteeTypeUpdatedEvent(GuaranteeTypeId guaranteetypeId)
    {
        GuaranteeTypeId = guaranteetypeId;
    }
}

public sealed class GuaranteeTypeDeletedEvent : DomainEvent
{
    public GuaranteeTypeId GuaranteeTypeId { get; }

    public GuaranteeTypeDeletedEvent(GuaranteeTypeId guaranteetypeId)
    {
        GuaranteeTypeId = guaranteetypeId;
    }
}
}
