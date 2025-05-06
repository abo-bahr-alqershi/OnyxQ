using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to PointCalculationTransaction entity
/// </summary>
public sealed class PointCalculationTransactionCreatedEvent : DomainEvent
{
    public PointCalculationTransactionId PointCalculationTransactionId { get; }

    public PointCalculationTransactionCreatedEvent(PointCalculationTransactionId pointcalculationtransactionId)
    {
        PointCalculationTransactionId = pointcalculationtransactionId;
    }
}

public sealed class PointCalculationTransactionUpdatedEvent : DomainEvent
{
    public PointCalculationTransactionId PointCalculationTransactionId { get; }

    public PointCalculationTransactionUpdatedEvent(PointCalculationTransactionId pointcalculationtransactionId)
    {
        PointCalculationTransactionId = pointcalculationtransactionId;
    }
}

public sealed class PointCalculationTransactionDeletedEvent : DomainEvent
{
    public PointCalculationTransactionId PointCalculationTransactionId { get; }

    public PointCalculationTransactionDeletedEvent(PointCalculationTransactionId pointcalculationtransactionId)
    {
        PointCalculationTransactionId = pointcalculationtransactionId;
    }
}
}
