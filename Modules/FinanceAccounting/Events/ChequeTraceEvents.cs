using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ChequeTrace entity
/// </summary>
public sealed class ChequeTraceCreatedEvent : DomainEvent
{
    public ChequeTraceId ChequeTraceId { get; }

    public ChequeTraceCreatedEvent(ChequeTraceId chequetraceId)
    {
        ChequeTraceId = chequetraceId;
    }
}

public sealed class ChequeTraceUpdatedEvent : DomainEvent
{
    public ChequeTraceId ChequeTraceId { get; }

    public ChequeTraceUpdatedEvent(ChequeTraceId chequetraceId)
    {
        ChequeTraceId = chequetraceId;
    }
}

public sealed class ChequeTraceDeletedEvent : DomainEvent
{
    public ChequeTraceId ChequeTraceId { get; }

    public ChequeTraceDeletedEvent(ChequeTraceId chequetraceId)
    {
        ChequeTraceId = chequetraceId;
    }
}
}
