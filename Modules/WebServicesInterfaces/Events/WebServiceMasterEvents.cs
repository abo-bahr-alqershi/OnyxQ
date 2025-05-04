using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Events
{
/// <summary>
/// Events related to WebServiceMaster entity
/// </summary>
public sealed class WebServiceMasterCreatedEvent : DomainEvent
{
    public WebServiceMasterId WebServiceMasterId { get; }

    public WebServiceMasterCreatedEvent(WebServiceMasterId webservicemasterId)
    {
        WebServiceMasterId = webservicemasterId;
    }
}

public sealed class WebServiceMasterUpdatedEvent : DomainEvent
{
    public WebServiceMasterId WebServiceMasterId { get; }

    public WebServiceMasterUpdatedEvent(WebServiceMasterId webservicemasterId)
    {
        WebServiceMasterId = webservicemasterId;
    }
}

public sealed class WebServiceMasterDeletedEvent : DomainEvent
{
    public WebServiceMasterId WebServiceMasterId { get; }

    public WebServiceMasterDeletedEvent(WebServiceMasterId webservicemasterId)
    {
        WebServiceMasterId = webservicemasterId;
    }
}
}
