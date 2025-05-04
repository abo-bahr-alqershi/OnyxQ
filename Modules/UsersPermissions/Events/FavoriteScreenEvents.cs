using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to FavoriteScreen entity
/// </summary>
public sealed class FavoriteScreenCreatedEvent : DomainEvent
{
    public FavoriteScreenId FavoriteScreenId { get; }

    public FavoriteScreenCreatedEvent(FavoriteScreenId favoritescreenId)
    {
        FavoriteScreenId = favoritescreenId;
    }
}

public sealed class FavoriteScreenUpdatedEvent : DomainEvent
{
    public FavoriteScreenId FavoriteScreenId { get; }

    public FavoriteScreenUpdatedEvent(FavoriteScreenId favoritescreenId)
    {
        FavoriteScreenId = favoritescreenId;
    }
}

public sealed class FavoriteScreenDeletedEvent : DomainEvent
{
    public FavoriteScreenId FavoriteScreenId { get; }

    public FavoriteScreenDeletedEvent(FavoriteScreenId favoritescreenId)
    {
        FavoriteScreenId = favoritescreenId;
    }
}
}
