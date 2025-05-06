using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionDetail entity
/// </summary>
public sealed class SalesmanCommissionDetailCreatedEvent : DomainEvent
{
    public SalesmanCommissionDetailId SalesmanCommissionDetailId { get; }

    public SalesmanCommissionDetailCreatedEvent(SalesmanCommissionDetailId salesmancommissiondetailId)
    {
        SalesmanCommissionDetailId = salesmancommissiondetailId;
    }
}

public sealed class SalesmanCommissionDetailUpdatedEvent : DomainEvent
{
    public SalesmanCommissionDetailId SalesmanCommissionDetailId { get; }

    public SalesmanCommissionDetailUpdatedEvent(SalesmanCommissionDetailId salesmancommissiondetailId)
    {
        SalesmanCommissionDetailId = salesmancommissiondetailId;
    }
}

public sealed class SalesmanCommissionDetailDeletedEvent : DomainEvent
{
    public SalesmanCommissionDetailId SalesmanCommissionDetailId { get; }

    public SalesmanCommissionDetailDeletedEvent(SalesmanCommissionDetailId salesmancommissiondetailId)
    {
        SalesmanCommissionDetailId = salesmancommissiondetailId;
    }
}
}
