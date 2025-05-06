using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.Common.Interfaces;

/// <summary>
/// واجهة للكيانات الجذرية في النطاق
/// </summary>
public interface IAggregateRoot
{
    /// <summary>
    /// قائمة أحداث النطاق
    /// </summary>
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    
    /// <summary>
    /// إضافة حدث نطاق
    /// </summary>
    /// <param name="domainEvent">الحدث المراد إضافته</param>
    void AddDomainEvent(IDomainEvent domainEvent);
    
    /// <summary>
    /// إزالة حدث نطاق
    /// </summary>
    /// <param name="domainEvent">الحدث المراد إزالته</param>
    void RemoveDomainEvent(IDomainEvent domainEvent);
    
    /// <summary>
    /// مسح جميع أحداث النطاق
    /// </summary>
    void ClearDomainEvents();
} 