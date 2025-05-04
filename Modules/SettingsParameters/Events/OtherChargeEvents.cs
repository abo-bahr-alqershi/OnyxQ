using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to OtherCharge entity
/// </summary>
public sealed class OtherChargeCreatedEvent : DomainEvent
{
    public OtherChargeId OtherChargeId { get; }

    public OtherChargeCreatedEvent(OtherChargeId otherchargeId)
    {
        OtherChargeId = otherchargeId;
    }
}

public sealed class OtherChargeUpdatedEvent : DomainEvent
{
    public OtherChargeId OtherChargeId { get; }

    public OtherChargeUpdatedEvent(OtherChargeId otherchargeId)
    {
        OtherChargeId = otherchargeId;
    }
}

public sealed class OtherChargeDeletedEvent : DomainEvent
{
    public OtherChargeId OtherChargeId { get; }

    public OtherChargeDeletedEvent(OtherChargeId otherchargeId)
    {
        OtherChargeId = otherchargeId;
    }
}
}
