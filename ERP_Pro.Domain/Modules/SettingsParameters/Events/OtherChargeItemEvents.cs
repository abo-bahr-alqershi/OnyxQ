using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to OtherChargeItem entity
/// </summary>
public sealed class OtherChargeItemCreatedEvent : DomainEvent
{
    public OtherChargeItemId OtherChargeItemId { get; }

    public OtherChargeItemCreatedEvent(OtherChargeItemId otherchargeitemId)
    {
        OtherChargeItemId = otherchargeitemId;
    }
}

public sealed class OtherChargeItemUpdatedEvent : DomainEvent
{
    public OtherChargeItemId OtherChargeItemId { get; }

    public OtherChargeItemUpdatedEvent(OtherChargeItemId otherchargeitemId)
    {
        OtherChargeItemId = otherchargeitemId;
    }
}

public sealed class OtherChargeItemDeletedEvent : DomainEvent
{
    public OtherChargeItemId OtherChargeItemId { get; }

    public OtherChargeItemDeletedEvent(OtherChargeItemId otherchargeitemId)
    {
        OtherChargeItemId = otherchargeitemId;
    }
}
}
