using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ParameterMessage entity
/// </summary>
public sealed class ParameterMessageCreatedEvent : DomainEvent
{
    public ParameterMessageId ParameterMessageId { get; }

    public ParameterMessageCreatedEvent(ParameterMessageId parametermessageId)
    {
        ParameterMessageId = parametermessageId;
    }
}

public sealed class ParameterMessageUpdatedEvent : DomainEvent
{
    public ParameterMessageId ParameterMessageId { get; }

    public ParameterMessageUpdatedEvent(ParameterMessageId parametermessageId)
    {
        ParameterMessageId = parametermessageId;
    }
}

public sealed class ParameterMessageDeletedEvent : DomainEvent
{
    public ParameterMessageId ParameterMessageId { get; }

    public ParameterMessageDeletedEvent(ParameterMessageId parametermessageId)
    {
        ParameterMessageId = parametermessageId;
    }
}
}
