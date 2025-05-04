using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CashCustomerLocation entity
/// </summary>
public sealed class CashCustomerLocationCreatedEvent : DomainEvent
{
    public CashCustomerLocationId CashCustomerLocationId { get; }

    public CashCustomerLocationCreatedEvent(CashCustomerLocationId cashcustomerlocationId)
    {
        CashCustomerLocationId = cashcustomerlocationId;
    }
}

public sealed class CashCustomerLocationUpdatedEvent : DomainEvent
{
    public CashCustomerLocationId CashCustomerLocationId { get; }

    public CashCustomerLocationUpdatedEvent(CashCustomerLocationId cashcustomerlocationId)
    {
        CashCustomerLocationId = cashcustomerlocationId;
    }
}

public sealed class CashCustomerLocationDeletedEvent : DomainEvent
{
    public CashCustomerLocationId CashCustomerLocationId { get; }

    public CashCustomerLocationDeletedEvent(CashCustomerLocationId cashcustomerlocationId)
    {
        CashCustomerLocationId = cashcustomerlocationId;
    }
}
}
