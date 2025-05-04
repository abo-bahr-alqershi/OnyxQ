using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCommissionCalculationMaster entity
/// </summary>
public sealed class CustomerCommissionCalculationMasterCreatedEvent : DomainEvent
{
    public CustomerCommissionCalculationMasterId CustomerCommissionCalculationMasterId { get; }

    public CustomerCommissionCalculationMasterCreatedEvent(CustomerCommissionCalculationMasterId customercommissioncalculationmasterId)
    {
        CustomerCommissionCalculationMasterId = customercommissioncalculationmasterId;
    }
}

public sealed class CustomerCommissionCalculationMasterUpdatedEvent : DomainEvent
{
    public CustomerCommissionCalculationMasterId CustomerCommissionCalculationMasterId { get; }

    public CustomerCommissionCalculationMasterUpdatedEvent(CustomerCommissionCalculationMasterId customercommissioncalculationmasterId)
    {
        CustomerCommissionCalculationMasterId = customercommissioncalculationmasterId;
    }
}

public sealed class CustomerCommissionCalculationMasterDeletedEvent : DomainEvent
{
    public CustomerCommissionCalculationMasterId CustomerCommissionCalculationMasterId { get; }

    public CustomerCommissionCalculationMasterDeletedEvent(CustomerCommissionCalculationMasterId customercommissioncalculationmasterId)
    {
        CustomerCommissionCalculationMasterId = customercommissioncalculationmasterId;
    }
}
}
