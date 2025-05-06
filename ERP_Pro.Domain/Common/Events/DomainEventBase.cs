using System;

namespace ERP_Pro.Domain.Common.Events
{
    public abstract class DomainEventBase : IDomainEvent
    {
        /// <summary>
        /// معرف الحدث
        /// </summary>
        public Guid Id { get; protected set; } = Guid.NewGuid();
        
        /// <summary>
        /// تاريخ حدوث الحدث
        /// </summary>
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
    }
}