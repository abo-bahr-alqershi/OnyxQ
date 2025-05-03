using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
    /// <summary>
    /// حدث إنشاء سجل نظام جديد
    /// Event for creating a new system log
    /// </summary>
    public class SystemLogCreatedEvent : DomainEvent
    {
        public SystemLog Log { get; }

        public SystemLogCreatedEvent(SystemLog log)
        {
            Log = log;
        }
    }
} 