using System;

namespace ERP_Pro.Domain.Common.Events
{
    /// <summary>
    /// واجهة لأحداث النطاق
    /// </summary>
    public interface IDomainEvent
    {
        /// <summary>
        /// معرف الحدث
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// تاريخ حدوث الحدث
        /// </summary>
        DateTime OccurredOn { get; }
    }
}