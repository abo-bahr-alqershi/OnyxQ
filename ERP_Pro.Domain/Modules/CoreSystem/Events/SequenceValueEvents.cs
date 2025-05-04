using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SequenceValue entity
/// </summary>
public sealed class SequenceValueCreatedEvent : DomainEvent
{
    public SequenceValueId SequenceValueId { get; }

    public SequenceValueCreatedEvent(SequenceValueId sequencevalueId)
    {
        SequenceValueId = sequencevalueId;
    }
}

public sealed class SequenceValueUpdatedEvent : DomainEvent
{
    public SequenceValueId SequenceValueId { get; }

    public SequenceValueUpdatedEvent(SequenceValueId sequencevalueId)
    {
        SequenceValueId = sequencevalueId;
    }
}

public sealed class SequenceValueDeletedEvent : DomainEvent
{
    public SequenceValueId SequenceValueId { get; }

    public SequenceValueDeletedEvent(SequenceValueId sequencevalueId)
    {
        SequenceValueId = sequencevalueId;
    }
}
}
