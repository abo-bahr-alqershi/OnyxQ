using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to LovSelect entity
/// </summary>
public sealed class LovSelectCreatedEvent : DomainEvent
{
    public LovSelectId LovSelectId { get; }

    public LovSelectCreatedEvent(LovSelectId lovselectId)
    {
        LovSelectId = lovselectId;
    }
}

public sealed class LovSelectUpdatedEvent : DomainEvent
{
    public LovSelectId LovSelectId { get; }

    public LovSelectUpdatedEvent(LovSelectId lovselectId)
    {
        LovSelectId = lovselectId;
    }
}

public sealed class LovSelectDeletedEvent : DomainEvent
{
    public LovSelectId LovSelectId { get; }

    public LovSelectDeletedEvent(LovSelectId lovselectId)
    {
        LovSelectId = lovselectId;
    }
}
}
