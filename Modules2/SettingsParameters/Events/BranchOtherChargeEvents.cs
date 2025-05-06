using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to BranchOtherCharge entity
/// </summary>
public sealed class BranchOtherChargeCreatedEvent : DomainEvent
{
    public BranchOtherChargeId BranchOtherChargeId { get; }

    public BranchOtherChargeCreatedEvent(BranchOtherChargeId branchotherchargeId)
    {
        BranchOtherChargeId = branchotherchargeId;
    }
}

public sealed class BranchOtherChargeUpdatedEvent : DomainEvent
{
    public BranchOtherChargeId BranchOtherChargeId { get; }

    public BranchOtherChargeUpdatedEvent(BranchOtherChargeId branchotherchargeId)
    {
        BranchOtherChargeId = branchotherchargeId;
    }
}

public sealed class BranchOtherChargeDeletedEvent : DomainEvent
{
    public BranchOtherChargeId BranchOtherChargeId { get; }

    public BranchOtherChargeDeletedEvent(BranchOtherChargeId branchotherchargeId)
    {
        BranchOtherChargeId = branchotherchargeId;
    }
}
}
