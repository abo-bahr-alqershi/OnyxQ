using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApexScreen entity
/// </summary>
public sealed class ApexScreenCreatedEvent : DomainEvent
{
    public ApexScreenId ApexScreenId { get; }

    public ApexScreenCreatedEvent(ApexScreenId apexscreenId)
    {
        ApexScreenId = apexscreenId;
    }
}

public sealed class ApexScreenUpdatedEvent : DomainEvent
{
    public ApexScreenId ApexScreenId { get; }

    public ApexScreenUpdatedEvent(ApexScreenId apexscreenId)
    {
        ApexScreenId = apexscreenId;
    }
}

public sealed class ApexScreenDeletedEvent : DomainEvent
{
    public ApexScreenId ApexScreenId { get; }

    public ApexScreenDeletedEvent(ApexScreenId apexscreenId)
    {
        ApexScreenId = apexscreenId;
    }
}
}
