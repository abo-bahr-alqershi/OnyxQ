using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SequenceControl entity
/// </summary>
public sealed class SequenceControlCreatedEvent : DomainEvent
{
    public SequenceControlId SequenceControlId { get; }

    public SequenceControlCreatedEvent(SequenceControlId sequencecontrolId)
    {
        SequenceControlId = sequencecontrolId;
    }
}

public sealed class SequenceControlUpdatedEvent : DomainEvent
{
    public SequenceControlId SequenceControlId { get; }

    public SequenceControlUpdatedEvent(SequenceControlId sequencecontrolId)
    {
        SequenceControlId = sequencecontrolId;
    }
}

public sealed class SequenceControlDeletedEvent : DomainEvent
{
    public SequenceControlId SequenceControlId { get; }

    public SequenceControlDeletedEvent(SequenceControlId sequencecontrolId)
    {
        SequenceControlId = sequencecontrolId;
    }
}
}
