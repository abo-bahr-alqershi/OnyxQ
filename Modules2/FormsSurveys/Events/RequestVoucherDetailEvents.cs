using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestVoucherDetail entity
/// </summary>
public sealed class RequestVoucherDetailCreatedEvent : DomainEvent
{
    public RequestVoucherDetailId RequestVoucherDetailId { get; }

    public RequestVoucherDetailCreatedEvent(RequestVoucherDetailId requestvoucherdetailId)
    {
        RequestVoucherDetailId = requestvoucherdetailId;
    }
}

public sealed class RequestVoucherDetailUpdatedEvent : DomainEvent
{
    public RequestVoucherDetailId RequestVoucherDetailId { get; }

    public RequestVoucherDetailUpdatedEvent(RequestVoucherDetailId requestvoucherdetailId)
    {
        RequestVoucherDetailId = requestvoucherdetailId;
    }
}

public sealed class RequestVoucherDetailDeletedEvent : DomainEvent
{
    public RequestVoucherDetailId RequestVoucherDetailId { get; }

    public RequestVoucherDetailDeletedEvent(RequestVoucherDetailId requestvoucherdetailId)
    {
        RequestVoucherDetailId = requestvoucherdetailId;
    }
}
}
