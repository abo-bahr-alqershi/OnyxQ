using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestModifyPriceMaster entity
/// </summary>
public sealed class RequestModifyPriceMasterCreatedEvent : DomainEvent
{
    public RequestModifyPriceMasterId RequestModifyPriceMasterId { get; }

    public RequestModifyPriceMasterCreatedEvent(RequestModifyPriceMasterId requestmodifypricemasterId)
    {
        RequestModifyPriceMasterId = requestmodifypricemasterId;
    }
}

public sealed class RequestModifyPriceMasterUpdatedEvent : DomainEvent
{
    public RequestModifyPriceMasterId RequestModifyPriceMasterId { get; }

    public RequestModifyPriceMasterUpdatedEvent(RequestModifyPriceMasterId requestmodifypricemasterId)
    {
        RequestModifyPriceMasterId = requestmodifypricemasterId;
    }
}

public sealed class RequestModifyPriceMasterDeletedEvent : DomainEvent
{
    public RequestModifyPriceMasterId RequestModifyPriceMasterId { get; }

    public RequestModifyPriceMasterDeletedEvent(RequestModifyPriceMasterId requestmodifypricemasterId)
    {
        RequestModifyPriceMasterId = requestmodifypricemasterId;
    }
}
}
