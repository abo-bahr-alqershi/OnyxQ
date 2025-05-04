using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCalculateCommissionMaster entity
/// </summary>
public sealed class SalesmanCalculateCommissionMasterCreatedEvent : DomainEvent
{
    public SalesmanCalculateCommissionMasterId SalesmanCalculateCommissionMasterId { get; }

    public SalesmanCalculateCommissionMasterCreatedEvent(SalesmanCalculateCommissionMasterId salesmancalculatecommissionmasterId)
    {
        SalesmanCalculateCommissionMasterId = salesmancalculatecommissionmasterId;
    }
}

public sealed class SalesmanCalculateCommissionMasterUpdatedEvent : DomainEvent
{
    public SalesmanCalculateCommissionMasterId SalesmanCalculateCommissionMasterId { get; }

    public SalesmanCalculateCommissionMasterUpdatedEvent(SalesmanCalculateCommissionMasterId salesmancalculatecommissionmasterId)
    {
        SalesmanCalculateCommissionMasterId = salesmancalculatecommissionmasterId;
    }
}

public sealed class SalesmanCalculateCommissionMasterDeletedEvent : DomainEvent
{
    public SalesmanCalculateCommissionMasterId SalesmanCalculateCommissionMasterId { get; }

    public SalesmanCalculateCommissionMasterDeletedEvent(SalesmanCalculateCommissionMasterId salesmancalculatecommissionmasterId)
    {
        SalesmanCalculateCommissionMasterId = salesmancalculatecommissionmasterId;
    }
}
}
