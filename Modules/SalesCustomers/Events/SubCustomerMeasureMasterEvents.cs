using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SubCustomerMeasureMaster entity
/// </summary>
public sealed class SubCustomerMeasureMasterCreatedEvent : DomainEvent
{
    public SubCustomerMeasureMasterId SubCustomerMeasureMasterId { get; }

    public SubCustomerMeasureMasterCreatedEvent(SubCustomerMeasureMasterId subcustomermeasuremasterId)
    {
        SubCustomerMeasureMasterId = subcustomermeasuremasterId;
    }
}

public sealed class SubCustomerMeasureMasterUpdatedEvent : DomainEvent
{
    public SubCustomerMeasureMasterId SubCustomerMeasureMasterId { get; }

    public SubCustomerMeasureMasterUpdatedEvent(SubCustomerMeasureMasterId subcustomermeasuremasterId)
    {
        SubCustomerMeasureMasterId = subcustomermeasuremasterId;
    }
}

public sealed class SubCustomerMeasureMasterDeletedEvent : DomainEvent
{
    public SubCustomerMeasureMasterId SubCustomerMeasureMasterId { get; }

    public SubCustomerMeasureMasterDeletedEvent(SubCustomerMeasureMasterId subcustomermeasuremasterId)
    {
        SubCustomerMeasureMasterId = subcustomermeasuremasterId;
    }
}
}
