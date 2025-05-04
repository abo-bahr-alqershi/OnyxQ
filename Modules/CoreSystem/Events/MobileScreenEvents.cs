using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to MobileScreen entity
/// </summary>
public sealed class MobileScreenCreatedEvent : DomainEvent
{
    public MobileScreenId MobileScreenId { get; }

    public MobileScreenCreatedEvent(MobileScreenId mobilescreenId)
    {
        MobileScreenId = mobilescreenId;
    }
}

public sealed class MobileScreenUpdatedEvent : DomainEvent
{
    public MobileScreenId MobileScreenId { get; }

    public MobileScreenUpdatedEvent(MobileScreenId mobilescreenId)
    {
        MobileScreenId = mobilescreenId;
    }
}

public sealed class MobileScreenDeletedEvent : DomainEvent
{
    public MobileScreenId MobileScreenId { get; }

    public MobileScreenDeletedEvent(MobileScreenId mobilescreenId)
    {
        MobileScreenId = mobilescreenId;
    }
}
}
