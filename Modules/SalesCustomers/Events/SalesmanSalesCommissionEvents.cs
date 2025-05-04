using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanSalesCommission entity
/// </summary>
public sealed class SalesmanSalesCommissionCreatedEvent : DomainEvent
{
    public SalesmanSalesCommissionId SalesmanSalesCommissionId { get; }

    public SalesmanSalesCommissionCreatedEvent(SalesmanSalesCommissionId salesmansalescommissionId)
    {
        SalesmanSalesCommissionId = salesmansalescommissionId;
    }
}

public sealed class SalesmanSalesCommissionUpdatedEvent : DomainEvent
{
    public SalesmanSalesCommissionId SalesmanSalesCommissionId { get; }

    public SalesmanSalesCommissionUpdatedEvent(SalesmanSalesCommissionId salesmansalescommissionId)
    {
        SalesmanSalesCommissionId = salesmansalescommissionId;
    }
}

public sealed class SalesmanSalesCommissionDeletedEvent : DomainEvent
{
    public SalesmanSalesCommissionId SalesmanSalesCommissionId { get; }

    public SalesmanSalesCommissionDeletedEvent(SalesmanSalesCommissionId salesmansalescommissionId)
    {
        SalesmanSalesCommissionId = salesmansalescommissionId;
    }
}
}
