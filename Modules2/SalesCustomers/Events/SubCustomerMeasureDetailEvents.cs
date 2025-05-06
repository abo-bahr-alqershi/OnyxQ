using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SubCustomerMeasureDetail entity
/// </summary>
public sealed class SubCustomerMeasureDetailCreatedEvent : DomainEvent
{
    public SubCustomerMeasureDetailId SubCustomerMeasureDetailId { get; }

    public SubCustomerMeasureDetailCreatedEvent(SubCustomerMeasureDetailId subcustomermeasuredetailId)
    {
        SubCustomerMeasureDetailId = subcustomermeasuredetailId;
    }
}

public sealed class SubCustomerMeasureDetailUpdatedEvent : DomainEvent
{
    public SubCustomerMeasureDetailId SubCustomerMeasureDetailId { get; }

    public SubCustomerMeasureDetailUpdatedEvent(SubCustomerMeasureDetailId subcustomermeasuredetailId)
    {
        SubCustomerMeasureDetailId = subcustomermeasuredetailId;
    }
}

public sealed class SubCustomerMeasureDetailDeletedEvent : DomainEvent
{
    public SubCustomerMeasureDetailId SubCustomerMeasureDetailId { get; }

    public SubCustomerMeasureDetailDeletedEvent(SubCustomerMeasureDetailId subcustomermeasuredetailId)
    {
        SubCustomerMeasureDetailId = subcustomermeasuredetailId;
    }
}
}
