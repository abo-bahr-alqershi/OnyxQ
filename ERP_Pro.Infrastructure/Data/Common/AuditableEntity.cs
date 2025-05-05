using ERP_Pro.Application.Abstractions.Base;

namespace ERP_Pro.Infrastructure.Data.Common;

public abstract class AuditableEntity<TId> : BaseEntity<TId>, IAuditableEntity<TId>
{
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
} 