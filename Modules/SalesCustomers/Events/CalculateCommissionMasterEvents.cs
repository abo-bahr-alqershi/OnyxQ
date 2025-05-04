using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CalculateCommissionMaster entity
/// </summary>
public sealed class CalculateCommissionMasterCreatedEvent : DomainEvent
{
    public CalculateCommissionMasterId CalculateCommissionMasterId { get; }

    public CalculateCommissionMasterCreatedEvent(CalculateCommissionMasterId calculatecommissionmasterId)
    {
        CalculateCommissionMasterId = calculatecommissionmasterId;
    }
}

public sealed class CalculateCommissionMasterUpdatedEvent : DomainEvent
{
    public CalculateCommissionMasterId CalculateCommissionMasterId { get; }

    public CalculateCommissionMasterUpdatedEvent(CalculateCommissionMasterId calculatecommissionmasterId)
    {
        CalculateCommissionMasterId = calculatecommissionmasterId;
    }
}

public sealed class CalculateCommissionMasterDeletedEvent : DomainEvent
{
    public CalculateCommissionMasterId CalculateCommissionMasterId { get; }

    public CalculateCommissionMasterDeletedEvent(CalculateCommissionMasterId calculatecommissionmasterId)
    {
        CalculateCommissionMasterId = calculatecommissionmasterId;
    }
}
}
