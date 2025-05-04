using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Events
{
/// <summary>
/// Events related to WebServiceColumn entity
/// </summary>
public sealed class WebServiceColumnCreatedEvent : DomainEvent
{
    public WebServiceColumnId WebServiceColumnId { get; }

    public WebServiceColumnCreatedEvent(WebServiceColumnId webservicecolumnId)
    {
        WebServiceColumnId = webservicecolumnId;
    }
}

public sealed class WebServiceColumnUpdatedEvent : DomainEvent
{
    public WebServiceColumnId WebServiceColumnId { get; }

    public WebServiceColumnUpdatedEvent(WebServiceColumnId webservicecolumnId)
    {
        WebServiceColumnId = webservicecolumnId;
    }
}

public sealed class WebServiceColumnDeletedEvent : DomainEvent
{
    public WebServiceColumnId WebServiceColumnId { get; }

    public WebServiceColumnDeletedEvent(WebServiceColumnId webservicecolumnId)
    {
        WebServiceColumnId = webservicecolumnId;
    }
}
}
