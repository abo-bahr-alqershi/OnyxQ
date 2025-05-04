using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectorCommissionSetupMaster entity
/// </summary>
public sealed class CollectorCommissionSetupMasterCreatedEvent : DomainEvent
{
    public CollectorCommissionSetupMasterId CollectorCommissionSetupMasterId { get; }

    public CollectorCommissionSetupMasterCreatedEvent(CollectorCommissionSetupMasterId collectorcommissionsetupmasterId)
    {
        CollectorCommissionSetupMasterId = collectorcommissionsetupmasterId;
    }
}

public sealed class CollectorCommissionSetupMasterUpdatedEvent : DomainEvent
{
    public CollectorCommissionSetupMasterId CollectorCommissionSetupMasterId { get; }

    public CollectorCommissionSetupMasterUpdatedEvent(CollectorCommissionSetupMasterId collectorcommissionsetupmasterId)
    {
        CollectorCommissionSetupMasterId = collectorcommissionsetupmasterId;
    }
}

public sealed class CollectorCommissionSetupMasterDeletedEvent : DomainEvent
{
    public CollectorCommissionSetupMasterId CollectorCommissionSetupMasterId { get; }

    public CollectorCommissionSetupMasterDeletedEvent(CollectorCommissionSetupMasterId collectorcommissionsetupmasterId)
    {
        CollectorCommissionSetupMasterId = collectorcommissionsetupmasterId;
    }
}
}
