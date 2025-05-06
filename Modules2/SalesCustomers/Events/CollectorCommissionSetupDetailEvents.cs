using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectorCommissionSetupDetail entity
/// </summary>
public sealed class CollectorCommissionSetupDetailCreatedEvent : DomainEvent
{
    public CollectorCommissionSetupDetailId CollectorCommissionSetupDetailId { get; }

    public CollectorCommissionSetupDetailCreatedEvent(CollectorCommissionSetupDetailId collectorcommissionsetupdetailId)
    {
        CollectorCommissionSetupDetailId = collectorcommissionsetupdetailId;
    }
}

public sealed class CollectorCommissionSetupDetailUpdatedEvent : DomainEvent
{
    public CollectorCommissionSetupDetailId CollectorCommissionSetupDetailId { get; }

    public CollectorCommissionSetupDetailUpdatedEvent(CollectorCommissionSetupDetailId collectorcommissionsetupdetailId)
    {
        CollectorCommissionSetupDetailId = collectorcommissionsetupdetailId;
    }
}

public sealed class CollectorCommissionSetupDetailDeletedEvent : DomainEvent
{
    public CollectorCommissionSetupDetailId CollectorCommissionSetupDetailId { get; }

    public CollectorCommissionSetupDetailDeletedEvent(CollectorCommissionSetupDetailId collectorcommissionsetupdetailId)
    {
        CollectorCommissionSetupDetailId = collectorcommissionsetupdetailId;
    }
}
}
