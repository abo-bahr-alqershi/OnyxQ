using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to BranchOtherChargeItem entity
/// </summary>
public sealed class BranchOtherChargeItemCreatedEvent : DomainEvent
{
    public BranchOtherChargeItemId BranchOtherChargeItemId { get; }

    public BranchOtherChargeItemCreatedEvent(BranchOtherChargeItemId branchotherchargeitemId)
    {
        BranchOtherChargeItemId = branchotherchargeitemId;
    }
}

public sealed class BranchOtherChargeItemUpdatedEvent : DomainEvent
{
    public BranchOtherChargeItemId BranchOtherChargeItemId { get; }

    public BranchOtherChargeItemUpdatedEvent(BranchOtherChargeItemId branchotherchargeitemId)
    {
        BranchOtherChargeItemId = branchotherchargeitemId;
    }
}

public sealed class BranchOtherChargeItemDeletedEvent : DomainEvent
{
    public BranchOtherChargeItemId BranchOtherChargeItemId { get; }

    public BranchOtherChargeItemDeletedEvent(BranchOtherChargeItemId branchotherchargeitemId)
    {
        BranchOtherChargeItemId = branchotherchargeitemId;
    }
}
}
