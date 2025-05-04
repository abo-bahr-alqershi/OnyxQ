using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionCalculationSubDetail entity
/// </summary>
public sealed class SalesmanCommissionCalculationSubDetailCreatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationSubDetailId SalesmanCommissionCalculationSubDetailId { get; }

    public SalesmanCommissionCalculationSubDetailCreatedEvent(SalesmanCommissionCalculationSubDetailId salesmancommissioncalculationsubdetailId)
    {
        SalesmanCommissionCalculationSubDetailId = salesmancommissioncalculationsubdetailId;
    }
}

public sealed class SalesmanCommissionCalculationSubDetailUpdatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationSubDetailId SalesmanCommissionCalculationSubDetailId { get; }

    public SalesmanCommissionCalculationSubDetailUpdatedEvent(SalesmanCommissionCalculationSubDetailId salesmancommissioncalculationsubdetailId)
    {
        SalesmanCommissionCalculationSubDetailId = salesmancommissioncalculationsubdetailId;
    }
}

public sealed class SalesmanCommissionCalculationSubDetailDeletedEvent : DomainEvent
{
    public SalesmanCommissionCalculationSubDetailId SalesmanCommissionCalculationSubDetailId { get; }

    public SalesmanCommissionCalculationSubDetailDeletedEvent(SalesmanCommissionCalculationSubDetailId salesmancommissioncalculationsubdetailId)
    {
        SalesmanCommissionCalculationSubDetailId = salesmancommissioncalculationsubdetailId;
    }
}
}
