using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to TelecomSetup entity
/// </summary>
public sealed class TelecomSetupCreatedEvent : DomainEvent
{
    public TelecomSetupId TelecomSetupId { get; }

    public TelecomSetupCreatedEvent(TelecomSetupId telecomsetupId)
    {
        TelecomSetupId = telecomsetupId;
    }
}

public sealed class TelecomSetupUpdatedEvent : DomainEvent
{
    public TelecomSetupId TelecomSetupId { get; }

    public TelecomSetupUpdatedEvent(TelecomSetupId telecomsetupId)
    {
        TelecomSetupId = telecomsetupId;
    }
}

public sealed class TelecomSetupDeletedEvent : DomainEvent
{
    public TelecomSetupId TelecomSetupId { get; }

    public TelecomSetupDeletedEvent(TelecomSetupId telecomsetupId)
    {
        TelecomSetupId = telecomsetupId;
    }
}
}
