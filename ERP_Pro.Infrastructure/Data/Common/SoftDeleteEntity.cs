using ERP_Pro.Application.Abstractions.Base;

namespace ERP_Pro.Infrastructure.Data.Common;

public abstract class SoftDeleteEntity<TId> : AuditableEntity<TId>, ISoftDelete
{
    public bool IsDeleted { get; set; }
    public DateTime? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
} 