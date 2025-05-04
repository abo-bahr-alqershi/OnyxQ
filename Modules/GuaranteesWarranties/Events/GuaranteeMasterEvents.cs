using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeMaster entity
/// </summary>
public sealed class GuaranteeMasterCreatedEvent : DomainEvent
{
    public GuaranteeMasterId GuaranteeMasterId { get; }

    public GuaranteeMasterCreatedEvent(GuaranteeMasterId guaranteemasterId)
    {
        GuaranteeMasterId = guaranteemasterId;
    }
}

public sealed class GuaranteeMasterUpdatedEvent : DomainEvent
{
    public GuaranteeMasterId GuaranteeMasterId { get; }

    public GuaranteeMasterUpdatedEvent(GuaranteeMasterId guaranteemasterId)
    {
        GuaranteeMasterId = guaranteemasterId;
    }
}

public sealed class GuaranteeMasterDeletedEvent : DomainEvent
{
    public GuaranteeMasterId GuaranteeMasterId { get; }

    public GuaranteeMasterDeletedEvent(GuaranteeMasterId guaranteemasterId)
    {
        GuaranteeMasterId = guaranteemasterId;
    }
}
}
