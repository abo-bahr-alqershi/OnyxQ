using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerMeasureDetail entity
/// </summary>
public sealed class CustomerMeasureDetailCreatedEvent : DomainEvent
{
    public CustomerMeasureDetailId CustomerMeasureDetailId { get; }

    public CustomerMeasureDetailCreatedEvent(CustomerMeasureDetailId customermeasuredetailId)
    {
        CustomerMeasureDetailId = customermeasuredetailId;
    }
}

public sealed class CustomerMeasureDetailUpdatedEvent : DomainEvent
{
    public CustomerMeasureDetailId CustomerMeasureDetailId { get; }

    public CustomerMeasureDetailUpdatedEvent(CustomerMeasureDetailId customermeasuredetailId)
    {
        CustomerMeasureDetailId = customermeasuredetailId;
    }
}

public sealed class CustomerMeasureDetailDeletedEvent : DomainEvent
{
    public CustomerMeasureDetailId CustomerMeasureDetailId { get; }

    public CustomerMeasureDetailDeletedEvent(CustomerMeasureDetailId customermeasuredetailId)
    {
        CustomerMeasureDetailId = customermeasuredetailId;
    }
}
}
