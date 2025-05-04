using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestModifyPriceDetail entity
/// </summary>
public sealed class RequestModifyPriceDetailCreatedEvent : DomainEvent
{
    public RequestModifyPriceDetailId RequestModifyPriceDetailId { get; }

    public RequestModifyPriceDetailCreatedEvent(RequestModifyPriceDetailId requestmodifypricedetailId)
    {
        RequestModifyPriceDetailId = requestmodifypricedetailId;
    }
}

public sealed class RequestModifyPriceDetailUpdatedEvent : DomainEvent
{
    public RequestModifyPriceDetailId RequestModifyPriceDetailId { get; }

    public RequestModifyPriceDetailUpdatedEvent(RequestModifyPriceDetailId requestmodifypricedetailId)
    {
        RequestModifyPriceDetailId = requestmodifypricedetailId;
    }
}

public sealed class RequestModifyPriceDetailDeletedEvent : DomainEvent
{
    public RequestModifyPriceDetailId RequestModifyPriceDetailId { get; }

    public RequestModifyPriceDetailDeletedEvent(RequestModifyPriceDetailId requestmodifypricedetailId)
    {
        RequestModifyPriceDetailId = requestmodifypricedetailId;
    }
}
}
