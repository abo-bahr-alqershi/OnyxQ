using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestVoucherMaster entity
/// </summary>
public sealed class RequestVoucherMasterCreatedEvent : DomainEvent
{
    public RequestVoucherMasterId RequestVoucherMasterId { get; }

    public RequestVoucherMasterCreatedEvent(RequestVoucherMasterId requestvouchermasterId)
    {
        RequestVoucherMasterId = requestvouchermasterId;
    }
}

public sealed class RequestVoucherMasterUpdatedEvent : DomainEvent
{
    public RequestVoucherMasterId RequestVoucherMasterId { get; }

    public RequestVoucherMasterUpdatedEvent(RequestVoucherMasterId requestvouchermasterId)
    {
        RequestVoucherMasterId = requestvouchermasterId;
    }
}

public sealed class RequestVoucherMasterDeletedEvent : DomainEvent
{
    public RequestVoucherMasterId RequestVoucherMasterId { get; }

    public RequestVoucherMasterDeletedEvent(RequestVoucherMasterId requestvouchermasterId)
    {
        RequestVoucherMasterId = requestvouchermasterId;
    }
}
}
