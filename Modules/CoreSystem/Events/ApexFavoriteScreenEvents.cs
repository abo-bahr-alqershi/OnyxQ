using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApexFavoriteScreen entity
/// </summary>
public sealed class ApexFavoriteScreenCreatedEvent : DomainEvent
{
    public ApexFavoriteScreenId ApexFavoriteScreenId { get; }

    public ApexFavoriteScreenCreatedEvent(ApexFavoriteScreenId apexfavoritescreenId)
    {
        ApexFavoriteScreenId = apexfavoritescreenId;
    }
}

public sealed class ApexFavoriteScreenUpdatedEvent : DomainEvent
{
    public ApexFavoriteScreenId ApexFavoriteScreenId { get; }

    public ApexFavoriteScreenUpdatedEvent(ApexFavoriteScreenId apexfavoritescreenId)
    {
        ApexFavoriteScreenId = apexfavoritescreenId;
    }
}

public sealed class ApexFavoriteScreenDeletedEvent : DomainEvent
{
    public ApexFavoriteScreenId ApexFavoriteScreenId { get; }

    public ApexFavoriteScreenDeletedEvent(ApexFavoriteScreenId apexfavoritescreenId)
    {
        ApexFavoriteScreenId = apexfavoritescreenId;
    }
}
}
