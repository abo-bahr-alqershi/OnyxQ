namespace ERP_Pro.Domain.Common.Base;

/// <summary>
/// فئة أساسية للكيانات القابلة للتدقيق
/// </summary>
/// <typeparam name="TId">نوع معرف الكيان</typeparam>
public abstract class AuditableEntity<TId> : Entity<TId>
{
    /// <summary>
    /// معرف المستخدم الذي أنشأ الكيان
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// تاريخ إنشاء الكيان
    /// </summary>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// معرف المستخدم الذي عدل الكيان آخر مرة
    /// </summary>
    public string? LastModifiedBy { get; set; }

    /// <summary>
    /// تاريخ آخر تعديل للكيان
    /// </summary>
    public DateTime? LastModifiedOn { get; set; }
    
    /// <summary>
    /// منشئ الفئة
    /// </summary>
    /// <param name="id">معرف الكيان</param>
    protected AuditableEntity(TId id) : base(id)
    {
        CreatedOn = DateTime.UtcNow;
    }
    
    /// <summary>
    /// منشئ للتسلسل
    /// </summary>
    protected AuditableEntity() : base()
    {
        // لا شيء هنا
    }
}