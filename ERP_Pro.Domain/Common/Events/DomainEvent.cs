namespace ERP_Pro.Domain.Common.Events;

using System;

/// <summary>
/// الفئة الأساسية لأحداث النطاق
/// </summary>
public abstract class DomainEvent : IDomainEvent
{
    /// <summary>
    /// معرف الحدث
    /// </summary>
    public Guid Id { get; }
    
    /// <summary>
    /// تاريخ حدوث الحدث
    /// </summary>
    public DateTime OccurredOn { get; }
    
    /// <summary>
    /// منشئ الفئة
    /// </summary>
    protected DomainEvent()
    {
        Id = Guid.NewGuid();
        OccurredOn = DateTime.UtcNow;
    }
} 