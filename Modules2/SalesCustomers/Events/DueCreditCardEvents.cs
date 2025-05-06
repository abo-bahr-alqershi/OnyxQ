using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DueCreditCard entity
/// </summary>
public sealed class DueCreditCardCreatedEvent : DomainEvent
{
    public DueCreditCardId DueCreditCardId { get; }

    public DueCreditCardCreatedEvent(DueCreditCardId duecreditcardId)
    {
        DueCreditCardId = duecreditcardId;
    }
}

public sealed class DueCreditCardUpdatedEvent : DomainEvent
{
    public DueCreditCardId DueCreditCardId { get; }

    public DueCreditCardUpdatedEvent(DueCreditCardId duecreditcardId)
    {
        DueCreditCardId = duecreditcardId;
    }
}

public sealed class DueCreditCardDeletedEvent : DomainEvent
{
    public DueCreditCardId DueCreditCardId { get; }

    public DueCreditCardDeletedEvent(DueCreditCardId duecreditcardId)
    {
        DueCreditCardId = duecreditcardId;
    }
}
}
