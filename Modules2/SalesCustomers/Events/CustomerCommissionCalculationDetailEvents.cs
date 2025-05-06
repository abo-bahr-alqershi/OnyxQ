using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCommissionCalculationDetail entity
/// </summary>
public sealed class CustomerCommissionCalculationDetailCreatedEvent : DomainEvent
{
    public CustomerCommissionCalculationDetailId CustomerCommissionCalculationDetailId { get; }

    public CustomerCommissionCalculationDetailCreatedEvent(CustomerCommissionCalculationDetailId customercommissioncalculationdetailId)
    {
        CustomerCommissionCalculationDetailId = customercommissioncalculationdetailId;
    }
}

public sealed class CustomerCommissionCalculationDetailUpdatedEvent : DomainEvent
{
    public CustomerCommissionCalculationDetailId CustomerCommissionCalculationDetailId { get; }

    public CustomerCommissionCalculationDetailUpdatedEvent(CustomerCommissionCalculationDetailId customercommissioncalculationdetailId)
    {
        CustomerCommissionCalculationDetailId = customercommissioncalculationdetailId;
    }
}

public sealed class CustomerCommissionCalculationDetailDeletedEvent : DomainEvent
{
    public CustomerCommissionCalculationDetailId CustomerCommissionCalculationDetailId { get; }

    public CustomerCommissionCalculationDetailDeletedEvent(CustomerCommissionCalculationDetailId customercommissioncalculationdetailId)
    {
        CustomerCommissionCalculationDetailId = customercommissioncalculationdetailId;
    }
}
}
