using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CashCustomerPointTrace entity
/// </summary>
public sealed class CashCustomerPointTraceCreatedEvent : DomainEvent
{
    public CashCustomerPointTraceId CashCustomerPointTraceId { get; }

    public CashCustomerPointTraceCreatedEvent(CashCustomerPointTraceId cashcustomerpointtraceId)
    {
        CashCustomerPointTraceId = cashcustomerpointtraceId;
    }
}

public sealed class CashCustomerPointTraceUpdatedEvent : DomainEvent
{
    public CashCustomerPointTraceId CashCustomerPointTraceId { get; }

    public CashCustomerPointTraceUpdatedEvent(CashCustomerPointTraceId cashcustomerpointtraceId)
    {
        CashCustomerPointTraceId = cashcustomerpointtraceId;
    }
}

public sealed class CashCustomerPointTraceDeletedEvent : DomainEvent
{
    public CashCustomerPointTraceId CashCustomerPointTraceId { get; }

    public CashCustomerPointTraceDeletedEvent(CashCustomerPointTraceId cashcustomerpointtraceId)
    {
        CashCustomerPointTraceId = cashcustomerpointtraceId;
    }
}
}
