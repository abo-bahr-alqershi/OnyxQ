using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to ExternalSystemOverrideWebApi entity
/// </summary>
public sealed class ExternalSystemOverrideWebApiCreatedEvent : DomainEvent
{
    public ExternalSystemOverrideWebApiId ExternalSystemOverrideWebApiId { get; }

    public ExternalSystemOverrideWebApiCreatedEvent(ExternalSystemOverrideWebApiId externalsystemoverridewebapiId)
    {
        ExternalSystemOverrideWebApiId = externalsystemoverridewebapiId;
    }
}

public sealed class ExternalSystemOverrideWebApiUpdatedEvent : DomainEvent
{
    public ExternalSystemOverrideWebApiId ExternalSystemOverrideWebApiId { get; }

    public ExternalSystemOverrideWebApiUpdatedEvent(ExternalSystemOverrideWebApiId externalsystemoverridewebapiId)
    {
        ExternalSystemOverrideWebApiId = externalsystemoverridewebapiId;
    }
}

public sealed class ExternalSystemOverrideWebApiDeletedEvent : DomainEvent
{
    public ExternalSystemOverrideWebApiId ExternalSystemOverrideWebApiId { get; }

    public ExternalSystemOverrideWebApiDeletedEvent(ExternalSystemOverrideWebApiId externalsystemoverridewebapiId)
    {
        ExternalSystemOverrideWebApiId = externalsystemoverridewebapiId;
    }
}
}
