namespace ERP_Pro.Application.Abstractions.Base;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
    DateTime? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
} 