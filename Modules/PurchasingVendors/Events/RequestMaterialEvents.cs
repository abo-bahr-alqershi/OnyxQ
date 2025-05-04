using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to RequestMaterial entity
/// </summary>
public sealed class RequestMaterialCreatedEvent : DomainEvent
{
    public RequestMaterialId RequestMaterialId { get; }

    public RequestMaterialCreatedEvent(RequestMaterialId requestmaterialId)
    {
        RequestMaterialId = requestmaterialId;
    }
}

public sealed class RequestMaterialUpdatedEvent : DomainEvent
{
    public RequestMaterialId RequestMaterialId { get; }

    public RequestMaterialUpdatedEvent(RequestMaterialId requestmaterialId)
    {
        RequestMaterialId = requestmaterialId;
    }
}

public sealed class RequestMaterialDeletedEvent : DomainEvent
{
    public RequestMaterialId RequestMaterialId { get; }

    public RequestMaterialDeletedEvent(RequestMaterialId requestmaterialId)
    {
        RequestMaterialId = requestmaterialId;
    }
}
}
