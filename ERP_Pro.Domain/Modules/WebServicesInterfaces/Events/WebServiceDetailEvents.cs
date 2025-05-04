using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Events
{
/// <summary>
/// Events related to WebServiceDetail entity
/// </summary>
public sealed class WebServiceDetailCreatedEvent : DomainEvent
{
    public WebServiceDetailId WebServiceDetailId { get; }

    public WebServiceDetailCreatedEvent(WebServiceDetailId webservicedetailId)
    {
        WebServiceDetailId = webservicedetailId;
    }
}

public sealed class WebServiceDetailUpdatedEvent : DomainEvent
{
    public WebServiceDetailId WebServiceDetailId { get; }

    public WebServiceDetailUpdatedEvent(WebServiceDetailId webservicedetailId)
    {
        WebServiceDetailId = webservicedetailId;
    }
}

public sealed class WebServiceDetailDeletedEvent : DomainEvent
{
    public WebServiceDetailId WebServiceDetailId { get; }

    public WebServiceDetailDeletedEvent(WebServiceDetailId webservicedetailId)
    {
        WebServiceDetailId = webservicedetailId;
    }
}
}
