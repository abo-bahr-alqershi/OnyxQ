using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCalculateCommissionDetail entity
/// </summary>
public sealed class SalesmanCalculateCommissionDetailCreatedEvent : DomainEvent
{
    public SalesmanCalculateCommissionDetailId SalesmanCalculateCommissionDetailId { get; }

    public SalesmanCalculateCommissionDetailCreatedEvent(SalesmanCalculateCommissionDetailId salesmancalculatecommissiondetailId)
    {
        SalesmanCalculateCommissionDetailId = salesmancalculatecommissiondetailId;
    }
}

public sealed class SalesmanCalculateCommissionDetailUpdatedEvent : DomainEvent
{
    public SalesmanCalculateCommissionDetailId SalesmanCalculateCommissionDetailId { get; }

    public SalesmanCalculateCommissionDetailUpdatedEvent(SalesmanCalculateCommissionDetailId salesmancalculatecommissiondetailId)
    {
        SalesmanCalculateCommissionDetailId = salesmancalculatecommissiondetailId;
    }
}

public sealed class SalesmanCalculateCommissionDetailDeletedEvent : DomainEvent
{
    public SalesmanCalculateCommissionDetailId SalesmanCalculateCommissionDetailId { get; }

    public SalesmanCalculateCommissionDetailDeletedEvent(SalesmanCalculateCommissionDetailId salesmancalculatecommissiondetailId)
    {
        SalesmanCalculateCommissionDetailId = salesmancalculatecommissiondetailId;
    }
}
}
