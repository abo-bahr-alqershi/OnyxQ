using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionCalculationDetail entity
/// </summary>
public sealed class SalesmanCommissionCalculationDetailCreatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationDetailId SalesmanCommissionCalculationDetailId { get; }

    public SalesmanCommissionCalculationDetailCreatedEvent(SalesmanCommissionCalculationDetailId salesmancommissioncalculationdetailId)
    {
        SalesmanCommissionCalculationDetailId = salesmancommissioncalculationdetailId;
    }
}

public sealed class SalesmanCommissionCalculationDetailUpdatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationDetailId SalesmanCommissionCalculationDetailId { get; }

    public SalesmanCommissionCalculationDetailUpdatedEvent(SalesmanCommissionCalculationDetailId salesmancommissioncalculationdetailId)
    {
        SalesmanCommissionCalculationDetailId = salesmancommissioncalculationdetailId;
    }
}

public sealed class SalesmanCommissionCalculationDetailDeletedEvent : DomainEvent
{
    public SalesmanCommissionCalculationDetailId SalesmanCommissionCalculationDetailId { get; }

    public SalesmanCommissionCalculationDetailDeletedEvent(SalesmanCommissionCalculationDetailId salesmancommissioncalculationdetailId)
    {
        SalesmanCommissionCalculationDetailId = salesmancommissioncalculationdetailId;
    }
}
}
