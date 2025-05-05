namespace ERP_Pro.Shared.Events.Base;

public abstract class EntityEvent<TEntity> : BaseEvent
    where TEntity : class
{
    public Guid EntityId { get; }
    public string EntityType => typeof(TEntity).Name;

    protected EntityEvent(Guid entityId)
    {
        EntityId = entityId;
    }
} 