using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to OtherChargeItemOthers entity
/// </summary>
public sealed class OtherChargeItemOthersCreatedEvent : DomainEvent
{
    public OtherChargeItemOthersId OtherChargeItemOthersId { get; }

    public OtherChargeItemOthersCreatedEvent(OtherChargeItemOthersId otherchargeitemothersId)
    {
        OtherChargeItemOthersId = otherchargeitemothersId;
    }
}

public sealed class OtherChargeItemOthersUpdatedEvent : DomainEvent
{
    public OtherChargeItemOthersId OtherChargeItemOthersId { get; }

    public OtherChargeItemOthersUpdatedEvent(OtherChargeItemOthersId otherchargeitemothersId)
    {
        OtherChargeItemOthersId = otherchargeitemothersId;
    }
}

public sealed class OtherChargeItemOthersDeletedEvent : DomainEvent
{
    public OtherChargeItemOthersId OtherChargeItemOthersId { get; }

    public OtherChargeItemOthersDeletedEvent(OtherChargeItemOthersId otherchargeitemothersId)
    {
        OtherChargeItemOthersId = otherchargeitemothersId;
    }
}
}
