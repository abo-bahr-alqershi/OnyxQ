using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerMeasure entity
/// </summary>
public sealed class CustomerMeasureCreatedEvent : DomainEvent
{
    public CustomerMeasureId CustomerMeasureId { get; }

    public CustomerMeasureCreatedEvent(CustomerMeasureId customermeasureId)
    {
        CustomerMeasureId = customermeasureId;
    }
}

public sealed class CustomerMeasureUpdatedEvent : DomainEvent
{
    public CustomerMeasureId CustomerMeasureId { get; }

    public CustomerMeasureUpdatedEvent(CustomerMeasureId customermeasureId)
    {
        CustomerMeasureId = customermeasureId;
    }
}

public sealed class CustomerMeasureDeletedEvent : DomainEvent
{
    public CustomerMeasureId CustomerMeasureId { get; }

    public CustomerMeasureDeletedEvent(CustomerMeasureId customermeasureId)
    {
        CustomerMeasureId = customermeasureId;
    }
}
}
