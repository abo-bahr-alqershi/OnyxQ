using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Events
{
/// <summary>
/// Events related to WebServiceRequestBody entity
/// </summary>
public sealed class WebServiceRequestBodyCreatedEvent : DomainEvent
{
    public WebServiceRequestBodyId WebServiceRequestBodyId { get; }

    public WebServiceRequestBodyCreatedEvent(WebServiceRequestBodyId webservicerequestbodyId)
    {
        WebServiceRequestBodyId = webservicerequestbodyId;
    }
}

public sealed class WebServiceRequestBodyUpdatedEvent : DomainEvent
{
    public WebServiceRequestBodyId WebServiceRequestBodyId { get; }

    public WebServiceRequestBodyUpdatedEvent(WebServiceRequestBodyId webservicerequestbodyId)
    {
        WebServiceRequestBodyId = webservicerequestbodyId;
    }
}

public sealed class WebServiceRequestBodyDeletedEvent : DomainEvent
{
    public WebServiceRequestBodyId WebServiceRequestBodyId { get; }

    public WebServiceRequestBodyDeletedEvent(WebServiceRequestBodyId webservicerequestbodyId)
    {
        WebServiceRequestBodyId = webservicerequestbodyId;
    }
}
}
