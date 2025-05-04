using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to MissingEquityDetailTemp entity
/// </summary>
public sealed class MissingEquityDetailTempCreatedEvent : DomainEvent
{
    public MissingEquityDetailTempId MissingEquityDetailTempId { get; }

    public MissingEquityDetailTempCreatedEvent(MissingEquityDetailTempId missingequitydetailtempId)
    {
        MissingEquityDetailTempId = missingequitydetailtempId;
    }
}

public sealed class MissingEquityDetailTempUpdatedEvent : DomainEvent
{
    public MissingEquityDetailTempId MissingEquityDetailTempId { get; }

    public MissingEquityDetailTempUpdatedEvent(MissingEquityDetailTempId missingequitydetailtempId)
    {
        MissingEquityDetailTempId = missingequitydetailtempId;
    }
}

public sealed class MissingEquityDetailTempDeletedEvent : DomainEvent
{
    public MissingEquityDetailTempId MissingEquityDetailTempId { get; }

    public MissingEquityDetailTempDeletedEvent(MissingEquityDetailTempId missingequitydetailtempId)
    {
        MissingEquityDetailTempId = missingequitydetailtempId;
    }
}
}
