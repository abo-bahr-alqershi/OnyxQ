namespace ERP_Pro.Application.Abstractions.Base;

public interface IEntity<TId>
{
    TId Id { get; }
} 