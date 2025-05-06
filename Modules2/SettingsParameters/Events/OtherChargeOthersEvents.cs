using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to OtherChargeOthers entity
/// </summary>
public sealed class OtherChargeOthersCreatedEvent : DomainEvent
{
    public OtherChargeOthersId OtherChargeOthersId { get; }

    public OtherChargeOthersCreatedEvent(OtherChargeOthersId otherchargeothersId)
    {
        OtherChargeOthersId = otherchargeothersId;
    }
}

public sealed class OtherChargeOthersUpdatedEvent : DomainEvent
{
    public OtherChargeOthersId OtherChargeOthersId { get; }

    public OtherChargeOthersUpdatedEvent(OtherChargeOthersId otherchargeothersId)
    {
        OtherChargeOthersId = otherchargeothersId;
    }
}

public sealed class OtherChargeOthersDeletedEvent : DomainEvent
{
    public OtherChargeOthersId OtherChargeOthersId { get; }

    public OtherChargeOthersDeletedEvent(OtherChargeOthersId otherchargeothersId)
    {
        OtherChargeOthersId = otherchargeothersId;
    }
}
}
