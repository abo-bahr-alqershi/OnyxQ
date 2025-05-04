using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeIncrease entity
/// </summary>
public sealed class GuaranteeIncreaseCreatedEvent : DomainEvent
{
    public GuaranteeIncreaseId GuaranteeIncreaseId { get; }

    public GuaranteeIncreaseCreatedEvent(GuaranteeIncreaseId guaranteeincreaseId)
    {
        GuaranteeIncreaseId = guaranteeincreaseId;
    }
}

public sealed class GuaranteeIncreaseUpdatedEvent : DomainEvent
{
    public GuaranteeIncreaseId GuaranteeIncreaseId { get; }

    public GuaranteeIncreaseUpdatedEvent(GuaranteeIncreaseId guaranteeincreaseId)
    {
        GuaranteeIncreaseId = guaranteeincreaseId;
    }
}

public sealed class GuaranteeIncreaseDeletedEvent : DomainEvent
{
    public GuaranteeIncreaseId GuaranteeIncreaseId { get; }

    public GuaranteeIncreaseDeletedEvent(GuaranteeIncreaseId guaranteeincreaseId)
    {
        GuaranteeIncreaseId = guaranteeincreaseId;
    }
}
}
