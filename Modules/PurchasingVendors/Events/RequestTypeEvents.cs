using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to RequestType entity
/// </summary>
public sealed class RequestTypeCreatedEvent : DomainEvent
{
    public RequestTypeId RequestTypeId { get; }

    public RequestTypeCreatedEvent(RequestTypeId requesttypeId)
    {
        RequestTypeId = requesttypeId;
    }
}

public sealed class RequestTypeUpdatedEvent : DomainEvent
{
    public RequestTypeId RequestTypeId { get; }

    public RequestTypeUpdatedEvent(RequestTypeId requesttypeId)
    {
        RequestTypeId = requesttypeId;
    }
}

public sealed class RequestTypeDeletedEvent : DomainEvent
{
    public RequestTypeId RequestTypeId { get; }

    public RequestTypeDeletedEvent(RequestTypeId requesttypeId)
    {
        RequestTypeId = requesttypeId;
    }
}
}
