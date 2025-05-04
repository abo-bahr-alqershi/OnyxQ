using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to MoveDataYearErrorLog entity
/// </summary>
public sealed class MoveDataYearErrorLogCreatedEvent : DomainEvent
{
    public MoveDataYearErrorLogId MoveDataYearErrorLogId { get; }

    public MoveDataYearErrorLogCreatedEvent(MoveDataYearErrorLogId movedatayearerrorlogId)
    {
        MoveDataYearErrorLogId = movedatayearerrorlogId;
    }
}

public sealed class MoveDataYearErrorLogUpdatedEvent : DomainEvent
{
    public MoveDataYearErrorLogId MoveDataYearErrorLogId { get; }

    public MoveDataYearErrorLogUpdatedEvent(MoveDataYearErrorLogId movedatayearerrorlogId)
    {
        MoveDataYearErrorLogId = movedatayearerrorlogId;
    }
}

public sealed class MoveDataYearErrorLogDeletedEvent : DomainEvent
{
    public MoveDataYearErrorLogId MoveDataYearErrorLogId { get; }

    public MoveDataYearErrorLogDeletedEvent(MoveDataYearErrorLogId movedatayearerrorlogId)
    {
        MoveDataYearErrorLogId = movedatayearerrorlogId;
    }
}
}
