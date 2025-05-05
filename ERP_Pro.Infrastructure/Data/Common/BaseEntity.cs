using ERP_Pro.Application.Abstractions.Base;

namespace ERP_Pro.Infrastructure.Data.Common;

public abstract class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; protected set; } = default!;
} 