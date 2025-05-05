namespace ERP_Pro.Application.Abstractions.Base;

public interface IAuditableEntity<TId> : IEntity<TId>
{
    string CreatedBy { get; set; }
    DateTime CreatedOn { get; set; }
    string? LastModifiedBy { get; set; }
    DateTime? LastModifiedOn { get; set; }
} 