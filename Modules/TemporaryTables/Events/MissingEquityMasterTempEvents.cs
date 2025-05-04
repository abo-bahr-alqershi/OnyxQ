using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to MissingEquityMasterTemp entity
/// </summary>
public sealed class MissingEquityMasterTempCreatedEvent : DomainEvent
{
    public MissingEquityMasterTempId MissingEquityMasterTempId { get; }

    public MissingEquityMasterTempCreatedEvent(MissingEquityMasterTempId missingequitymastertempId)
    {
        MissingEquityMasterTempId = missingequitymastertempId;
    }
}

public sealed class MissingEquityMasterTempUpdatedEvent : DomainEvent
{
    public MissingEquityMasterTempId MissingEquityMasterTempId { get; }

    public MissingEquityMasterTempUpdatedEvent(MissingEquityMasterTempId missingequitymastertempId)
    {
        MissingEquityMasterTempId = missingequitymastertempId;
    }
}

public sealed class MissingEquityMasterTempDeletedEvent : DomainEvent
{
    public MissingEquityMasterTempId MissingEquityMasterTempId { get; }

    public MissingEquityMasterTempDeletedEvent(MissingEquityMasterTempId missingequitymastertempId)
    {
        MissingEquityMasterTempId = missingequitymastertempId;
    }
}
}
