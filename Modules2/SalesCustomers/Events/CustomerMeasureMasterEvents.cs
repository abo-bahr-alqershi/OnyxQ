using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerMeasureMaster entity
/// </summary>
public sealed class CustomerMeasureMasterCreatedEvent : DomainEvent
{
    public CustomerMeasureMasterId CustomerMeasureMasterId { get; }

    public CustomerMeasureMasterCreatedEvent(CustomerMeasureMasterId customermeasuremasterId)
    {
        CustomerMeasureMasterId = customermeasuremasterId;
    }
}

public sealed class CustomerMeasureMasterUpdatedEvent : DomainEvent
{
    public CustomerMeasureMasterId CustomerMeasureMasterId { get; }

    public CustomerMeasureMasterUpdatedEvent(CustomerMeasureMasterId customermeasuremasterId)
    {
        CustomerMeasureMasterId = customermeasuremasterId;
    }
}

public sealed class CustomerMeasureMasterDeletedEvent : DomainEvent
{
    public CustomerMeasureMasterId CustomerMeasureMasterId { get; }

    public CustomerMeasureMasterDeletedEvent(CustomerMeasureMasterId customermeasuremasterId)
    {
        CustomerMeasureMasterId = customermeasuremasterId;
    }
}
}
