using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to MobileScreenName entity
/// </summary>
public sealed class MobileScreenNameCreatedEvent : DomainEvent
{
    public MobileScreenNameId MobileScreenNameId { get; }

    public MobileScreenNameCreatedEvent(MobileScreenNameId mobilescreennameId)
    {
        MobileScreenNameId = mobilescreennameId;
    }
}

public sealed class MobileScreenNameUpdatedEvent : DomainEvent
{
    public MobileScreenNameId MobileScreenNameId { get; }

    public MobileScreenNameUpdatedEvent(MobileScreenNameId mobilescreennameId)
    {
        MobileScreenNameId = mobilescreennameId;
    }
}

public sealed class MobileScreenNameDeletedEvent : DomainEvent
{
    public MobileScreenNameId MobileScreenNameId { get; }

    public MobileScreenNameDeletedEvent(MobileScreenNameId mobilescreennameId)
    {
        MobileScreenNameId = mobilescreennameId;
    }
}
}
