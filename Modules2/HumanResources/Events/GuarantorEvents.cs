using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to Guarantor entity
/// </summary>
public sealed class GuarantorCreatedEvent : DomainEvent
{
    public GuarantorId GuarantorId { get; }

    public GuarantorCreatedEvent(GuarantorId guarantorId)
    {
        GuarantorId = guarantorId;
    }
}

public sealed class GuarantorUpdatedEvent : DomainEvent
{
    public GuarantorId GuarantorId { get; }

    public GuarantorUpdatedEvent(GuarantorId guarantorId)
    {
        GuarantorId = guarantorId;
    }
}

public sealed class GuarantorDeletedEvent : DomainEvent
{
    public GuarantorId GuarantorId { get; }

    public GuarantorDeletedEvent(GuarantorId guarantorId)
    {
        GuarantorId = guarantorId;
    }
}
}
