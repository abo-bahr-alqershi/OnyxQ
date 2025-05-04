using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesPlanDetail entity
/// </summary>
public sealed class SalesPlanDetailCreatedEvent : DomainEvent
{
    public SalesPlanDetailId SalesPlanDetailId { get; }

    public SalesPlanDetailCreatedEvent(SalesPlanDetailId salesplandetailId)
    {
        SalesPlanDetailId = salesplandetailId;
    }
}

public sealed class SalesPlanDetailUpdatedEvent : DomainEvent
{
    public SalesPlanDetailId SalesPlanDetailId { get; }

    public SalesPlanDetailUpdatedEvent(SalesPlanDetailId salesplandetailId)
    {
        SalesPlanDetailId = salesplandetailId;
    }
}

public sealed class SalesPlanDetailDeletedEvent : DomainEvent
{
    public SalesPlanDetailId SalesPlanDetailId { get; }

    public SalesPlanDetailDeletedEvent(SalesPlanDetailId salesplandetailId)
    {
        SalesPlanDetailId = salesplandetailId;
    }
}
}
