// AggregateRoot.cs
// تم إنشاؤه تلقائيًا.

using System.Collections.Generic;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Domain.Common.Aggregates
{
    /// <summary>
    /// فئة أساسية للجذور التجميعية في النطاق
    /// </summary>
    /// <typeparam name="TId">نوع المعرف</typeparam>
    public abstract class AggregateRoot<TId> : IAggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        
        /// <summary>
        /// معرف الجذر التجميعي
        /// </summary>
        public TId Id { get; protected set; }
        
        /// <summary>
        /// أحداث النطاق
        /// </summary>
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        
        /// <summary>
        /// إضافة حدث نطاق
        /// </summary>
        /// <param name="domainEvent">الحدث المراد إضافته</param>
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
        
        /// <summary>
        /// إزالة حدث نطاق
        /// </summary>
        /// <param name="domainEvent">الحدث المراد إزالته</param>
        public void RemoveDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }
        
        /// <summary>
        /// مسح جميع أحداث النطاق
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}