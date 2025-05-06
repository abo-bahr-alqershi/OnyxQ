using System.Threading.Tasks;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Application.Common.Interfaces
{
    /// <summary>
    /// خدمة أحداث النطاق
    /// </summary>
    public interface IDomainEventService
    {
        /// <summary>
        /// نشر حدث نطاق
        /// </summary>
        /// <param name="domainEvent">الحدث المراد نشره</param>
        Task Publish(IDomainEvent domainEvent);
    }
} 