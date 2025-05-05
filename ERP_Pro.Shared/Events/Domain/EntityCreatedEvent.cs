using ERP_Pro.Shared.Events.Base;

namespace ERP_Pro.Shared.Events.Domain;

public class EntityCreatedEvent<TEntity> : EntityEvent<TEntity>
    where TEntity : class
{
    public TEntity Entity { get; }

    public EntityCreatedEvent(Guid entityId, TEntity entity) : base(entityId)
    {
        Entity = entity;
    }
} 