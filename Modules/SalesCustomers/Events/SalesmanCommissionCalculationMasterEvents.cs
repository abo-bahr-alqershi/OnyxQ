using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionCalculationMaster entity
/// </summary>
public sealed class SalesmanCommissionCalculationMasterCreatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationMasterId SalesmanCommissionCalculationMasterId { get; }

    public SalesmanCommissionCalculationMasterCreatedEvent(SalesmanCommissionCalculationMasterId salesmancommissioncalculationmasterId)
    {
        SalesmanCommissionCalculationMasterId = salesmancommissioncalculationmasterId;
    }
}

public sealed class SalesmanCommissionCalculationMasterUpdatedEvent : DomainEvent
{
    public SalesmanCommissionCalculationMasterId SalesmanCommissionCalculationMasterId { get; }

    public SalesmanCommissionCalculationMasterUpdatedEvent(SalesmanCommissionCalculationMasterId salesmancommissioncalculationmasterId)
    {
        SalesmanCommissionCalculationMasterId = salesmancommissioncalculationmasterId;
    }
}

public sealed class SalesmanCommissionCalculationMasterDeletedEvent : DomainEvent
{
    public SalesmanCommissionCalculationMasterId SalesmanCommissionCalculationMasterId { get; }

    public SalesmanCommissionCalculationMasterDeletedEvent(SalesmanCommissionCalculationMasterId salesmancommissioncalculationmasterId)
    {
        SalesmanCommissionCalculationMasterId = salesmancommissioncalculationmasterId;
    }
}
}
