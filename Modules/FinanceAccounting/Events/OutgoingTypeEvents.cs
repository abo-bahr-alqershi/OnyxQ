using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to OutgoingType entity
/// </summary>
public sealed class OutgoingTypeCreatedEvent : DomainEvent
{
    public OutgoingTypeId OutgoingTypeId { get; }

    public OutgoingTypeCreatedEvent(OutgoingTypeId outgoingtypeId)
    {
        OutgoingTypeId = outgoingtypeId;
    }
}

public sealed class OutgoingTypeUpdatedEvent : DomainEvent
{
    public OutgoingTypeId OutgoingTypeId { get; }

    public OutgoingTypeUpdatedEvent(OutgoingTypeId outgoingtypeId)
    {
        OutgoingTypeId = outgoingtypeId;
    }
}

public sealed class OutgoingTypeDeletedEvent : DomainEvent
{
    public OutgoingTypeId OutgoingTypeId { get; }

    public OutgoingTypeDeletedEvent(OutgoingTypeId outgoingtypeId)
    {
        OutgoingTypeId = outgoingtypeId;
    }
}
}
