using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to LogCheckBeforeClose entity
/// </summary>
public sealed class LogCheckBeforeCloseCreatedEvent : DomainEvent
{
    public LogCheckBeforeCloseId LogCheckBeforeCloseId { get; }

    public LogCheckBeforeCloseCreatedEvent(LogCheckBeforeCloseId logcheckbeforecloseId)
    {
        LogCheckBeforeCloseId = logcheckbeforecloseId;
    }
}

public sealed class LogCheckBeforeCloseUpdatedEvent : DomainEvent
{
    public LogCheckBeforeCloseId LogCheckBeforeCloseId { get; }

    public LogCheckBeforeCloseUpdatedEvent(LogCheckBeforeCloseId logcheckbeforecloseId)
    {
        LogCheckBeforeCloseId = logcheckbeforecloseId;
    }
}

public sealed class LogCheckBeforeCloseDeletedEvent : DomainEvent
{
    public LogCheckBeforeCloseId LogCheckBeforeCloseId { get; }

    public LogCheckBeforeCloseDeletedEvent(LogCheckBeforeCloseId logcheckbeforecloseId)
    {
        LogCheckBeforeCloseId = logcheckbeforecloseId;
    }
}
}
