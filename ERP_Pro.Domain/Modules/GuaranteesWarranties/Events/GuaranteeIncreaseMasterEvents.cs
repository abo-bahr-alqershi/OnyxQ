using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeIncreaseMaster entity
/// </summary>
public sealed class GuaranteeIncreaseMasterCreatedEvent : DomainEvent
{
    public GuaranteeIncreaseMasterId GuaranteeIncreaseMasterId { get; }

    public GuaranteeIncreaseMasterCreatedEvent(GuaranteeIncreaseMasterId guaranteeincreasemasterId)
    {
        GuaranteeIncreaseMasterId = guaranteeincreasemasterId;
    }
}

public sealed class GuaranteeIncreaseMasterUpdatedEvent : DomainEvent
{
    public GuaranteeIncreaseMasterId GuaranteeIncreaseMasterId { get; }

    public GuaranteeIncreaseMasterUpdatedEvent(GuaranteeIncreaseMasterId guaranteeincreasemasterId)
    {
        GuaranteeIncreaseMasterId = guaranteeincreasemasterId;
    }
}

public sealed class GuaranteeIncreaseMasterDeletedEvent : DomainEvent
{
    public GuaranteeIncreaseMasterId GuaranteeIncreaseMasterId { get; }

    public GuaranteeIncreaseMasterDeletedEvent(GuaranteeIncreaseMasterId guaranteeincreasemasterId)
    {
        GuaranteeIncreaseMasterId = guaranteeincreasemasterId;
    }
}
}
